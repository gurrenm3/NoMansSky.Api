using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.IO;
using Reloaded.ModHelper;
using System.Xml.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Pak file, which is the same as a PSArc file.
    /// <br/>Thanks to cmkushnir#4490 for all their help making this.
    /// <br/>Code is heavily based off of https://github.com/cmkushnir/NMSModBuilder/tree/main/Common/NMS/PAK
    /// </summary>
    public class PakFile
    {
        public PakHeader Header { get; private set; }
        public PakFileEntry Manifest { get; private set; }
        public List<PakFileEntry> Entries { get; private set; } = new List<PakFileEntry>();

        public int BlockCount { get; protected set; } = 0;
        public long[] Blocks { get; protected set; } = null;

        /// <summary>
        /// The path of the file used to create this pak file.
        /// </summary>
        public readonly string filePath;

        public PakFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new FileNotFoundException("Cannot read pak file because provided path is null or doesn't exist.");

            this.filePath = filePath;
        }

        /// <summary>
        /// Attempts to initialize this Pak file. Returns true if successful, otherwise false.
        /// </summary>
        /// <returns></returns>
        public bool Init()
        {
            using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var reader = new EndianBinaryReader(fs, EndianType.Big);

            Header = new PakHeader(reader, filePath);
            if (!Header.Init())
            {
                Mod.WriteLine($"Couldn't load header for Pak file at {filePath}");
                return false;
            }

            ReadTOC(fs);
            ReadBlocks(fs);
            ReadManifest(fs);
            return true;
        }

        private void ReadTOC(Stream PAK)
        {
            PAK.Position = 0x20;  // skip 32 byte header
            var reader = new EndianBinaryReader(PAK, EndianType.Big);

            // manifest always first item
            var hash = reader.ReadBytes(16);  // ignore, md5 hash of item path
            var index = reader.ReadUInt32();
            var length = reader.ReadUInt40();
            var offset = reader.ReadUInt40();
            Manifest = new("", (int)index, (long)length, (long)offset);

            for (var entry = 0; entry++ < Header.TotalEntries;)
            {
                hash = reader.ReadBytes(16);
                index = reader.ReadUInt32();
                length = reader.ReadUInt40();
                offset = reader.ReadUInt40();
                Entries.Add(new("", (int)index, (long)length, (long)offset));
            }
        }

        private void ReadBlocks(Stream PAK)
        {
            PAK.Position = 0x20 + ((1 + Header.TotalEntries) * Header.TocEntrySize);
            var reader = new EndianBinaryReader(PAK, EndianType.Big);

            byte block_bytes = 1;
            var accum = 256;

            do
            {
                block_bytes++;
                accum *= 256;
            } while (accum < Header.BlockSize);

            BlockCount = (int)(Header.TocLength - (int)PAK.Position) / block_bytes;
            Blocks = new long[BlockCount];

            switch (block_bytes)
            {
                case 2:
                    {
                        for (int i = 0, offset = 0; i < BlockCount; i++, offset += block_bytes)
                        {
                            Blocks[i] = reader.ReadUInt16();
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0, offset = 0; i < BlockCount; i++, offset += block_bytes)
                        {
                            Blocks[i] = reader.ReadUInt24();
                        }
                        break;
                    }
                case 4:
                    {
                        for (int i = 0, offset = 0; i < BlockCount; i++, offset += block_bytes)
                        {
                            Blocks[i] = reader.ReadUInt32();
                        }
                        break;
                    }
            }

            if (BlockCount < 1)
            {
                throw new Exception($" - No block sizes");
            }
        }

        private void ReadManifest(Stream PAK)
        {
            var stream = Extract(Manifest, PAK);
            using var sr = new StreamReader(stream);
            Entries.ForEach(entry =>
            {
                entry.Path = sr.ReadLine()?.Replace("/", "\\").TrimEnd('\\');
                if (!string.IsNullOrEmpty(entry.Path) && entry.Path.EndsWith(".MBIN"))
                {
                    var header = ReadMbinHeader(entry, PAK);
                    entry.MbinType = header.ClassName;
                    entry.Path = entry.Path.Replace(".MBIN", "");
                }
            });
        }

        private MbinHeader ReadMbinHeader(PakFileEntry entry, Stream PAK)
        {
            var uncompressed_length = (int)Math.Min(entry.UncompressedSize, Header.BlockSize);

            var compressed_length = (int)Blocks[entry.Index];
            if (compressed_length == 0) compressed_length = uncompressed_length;  // full uncompressed

            var compressed_bytes = new byte[compressed_length];
            var uncompressed_bytes = new byte[uncompressed_length];
            var uncompressed_stream = new MemoryStream(uncompressed_bytes);
            var read_length = 0;

            lock (PAK)
            {
                PAK.Position = entry.FileOffset;
                read_length = PAK.Read(compressed_bytes, 0, compressed_length);
            }
            if (read_length != compressed_length) return null;  // error, corrupt data

            var uncompressed_position = uncompressed_stream.Position;

            if (compressed_length != uncompressed_length)
            {
                try
                {  // think it's a compressed block, try to inflate
                    var compressed_stream = new MemoryStream(compressed_bytes, 0, compressed_length);
                    using (var decompressor = new ZlibStream(compressed_stream, CompressionMode.Decompress))
                    {
                        decompressor.CopyTo(uncompressed_stream);
                    }
                }
                catch { return null; }
            }
            if (uncompressed_position == uncompressed_stream.Position)
            {
                // didn't inflate, just copy block assuming it's uncompressed
                uncompressed_stream.Write(compressed_bytes, 0, compressed_length);
            }

            return new MbinHeader(uncompressed_stream);
        }


        private static Stream MemoryOrTempFile(long CAPACITY, int BUFFER_SIZE = 65536)
        {
            Stream stream;
            if (CAPACITY < Int32.MaxValue)
            {
                stream = new MemoryStream((int)CAPACITY);
            }
            else
            {
                var temp = Path.GetTempFileName();
                stream = new FileStream(temp,
                    FileMode.Open,
                    FileAccess.ReadWrite,
                    FileShare.None,
                    BUFFER_SIZE,
                    FileOptions.DeleteOnClose
                );
            }
            stream.Position = 0;
            return stream;
        }

        // taken from https://github.com/cmkushnir/NMSModBuilder/blob/3316966e4db1b53b8e4e2135ae98eaab37818b56/Common/NMS/PAK/PAK.File.Loader.cs#L397
        private Stream Extract(PakFileEntry INFO, Stream PAK)
        {
            var compressed_offset = INFO.FileOffset;  // all compressed blocks for info start at INFO.Offset and are contiguous
            var compressed_bytes = new byte[Header.BlockSize];
            var raw = MemoryOrTempFile(INFO.UncompressedSize, Header.BlockSize);

            for (var block_index = INFO.Index; raw.Length < INFO.UncompressedSize; ++block_index)
            {
                var remaining_length = INFO.UncompressedSize - raw.Length;
                var compressed_length = (int)Blocks[block_index];
                if (compressed_length == 0) compressed_length = (int)Math.Min(remaining_length, Header.BlockSize);

                var read_length = 0;
                lock (PAK)
                {
                    PAK.Position = compressed_offset;
                    read_length = PAK.Read(compressed_bytes, 0, compressed_length);
                }
                if (read_length != compressed_length)
                {
                    Console.WriteLine($" - Could only read {read_length} of {compressed_length} bytes for block[{block_index}]");
                    return null;
                }
                compressed_offset += read_length;  // next compressed block

                var raw_position = raw.Position;

                if (Blocks[block_index] != 0 &&
                    compressed_length != remaining_length
                )
                {
                    try
                    {
                        var compressed_stream = new MemoryStream(compressed_bytes, 0, compressed_length);


                        using (var decompressor = new ZlibStream(compressed_stream, CompressionMode.Decompress))
                        {
                            decompressor.CopyTo(raw);
                        }
                    }
                    catch (Exception EX)
                    {
                        Console.WriteLine($" - Block[{block_index}] is {compressed_length} byte compressed (?) block, starts with 0x{compressed_bytes[0]:x02}, 0x{compressed_bytes[1]:x02}, will assume uncompressed");
                    }
                }
                if (raw_position == raw.Position)
                {
                    raw.Write(compressed_bytes, 0, compressed_length);
                }
            }

            raw.Position = 0;  // most callers will assume this
            return raw;
        }
    }
}
