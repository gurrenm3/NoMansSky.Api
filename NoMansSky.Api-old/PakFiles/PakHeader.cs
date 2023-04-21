using Reloaded.ModHelper;
using System;
using System.Text;

namespace NoMansSky.Api
{
    /// <summary>
    /// Contains header info about Pak Files.
    /// <br/>Thanks to cmkushnir#4490 for all their help making this.
    /// <br/>Code is heavily based off of https://github.com/cmkushnir/NMSModBuilder/tree/main/Common/NMS/PAK
    /// </summary>
    public sealed class PakHeader
    {
        public const string headerText = "PSAR";

        /// <summary>
        /// The bytes of <see cref="headerText"/>. Indicates whether or not this file is a psarc file.
        /// </summary>
        public readonly int headerTextBytes = 0x50534152; // equal to Encoding.Default.GetBytes(headerText)

        /// <summary>
        /// 
        /// </summary>
        public ushort MajorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ushort MinorVersion { get; set; }

        /// <summary>
        /// The type of compression used for this file.
        /// </summary>
        public CompressionType Compression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TocLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TocEntrySize { get; set; }

        /// <summary>
        /// Total number of entries in this file, including the manifest.
        /// </summary>
        public int TotalEntries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int BlockSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ArchiveFlags Flags { get; set; }

        /// <summary>
        /// The filepath for this file.
        /// </summary>
        public readonly string filePath;

        private EndianBinaryReader psarcStream;

        public PakHeader(EndianBinaryReader psarcStream, string filePath)
        {
            this.filePath = filePath;
            this.psarcStream = psarcStream;
        }

        /// <summary>
        /// Attempts to initialize this Pak file header. Returns true if successful, otherwise false.
        /// </summary>
        /// <returns></returns>
        public bool Init()
        {
            if (psarcStream == null)
            {
                Mod.WriteLine("Can't create header. Provided PSArc stream was null!", LogLevel.Error);
                return false;
            }

            var magic = psarcStream.ReadInt32();
            if (magic != headerTextBytes)
            {
                Mod.WriteLine($"Tried decompiling a file that isn't a PSArc file! It doesn't have correct \"magic\" token. Magic token found: {headerTextBytes}", LogLevel.Error);
                return false;
            }

            MajorVersion = (ushort)psarcStream.ReadInt16();
            MinorVersion = (ushort)psarcStream.ReadInt16();

            var compressionBytes = psarcStream.ReadBytes(4);
            Array.Reverse(compressionBytes);
            string compressionText = Encoding.Default.GetString(compressionBytes);
            if (!Enum.TryParse<CompressionType>(compressionText, ignoreCase: true, out var compression))
            {
                Mod.WriteLine("Failed to create header for the PSArc File! The compression type was invalid!", LogLevel.Error);
                return false;
            }

            Compression = compression;

            TocLength = psarcStream.ReadInt32();
            TocEntrySize = psarcStream.ReadInt32();
            TotalEntries = psarcStream.ReadInt32() - 1; // ignoring manifest file
            BlockSize = psarcStream.ReadInt32();

            uint flags = (uint)psarcStream.ReadInt32();
            if (flags > 2)
            {
                Mod.WriteLine("Failed to create header for the PSArc File! The archive flags were invalid!", LogLevel.Error);
                return false;
            }

            Flags = (ArchiveFlags)flags;
            return true;
        }

        public override string ToString()
        {
            string output = $"v{MajorVersion}.{MinorVersion}" +
                $"\nCompression: {Compression}" +
                $"\nTocLength: {TocLength}" +
                $"\nTocEntrySize: {TocEntrySize}" +
                $"\nTocEntryCount: {TotalEntries}" +
                $"\nBlockSize: {BlockSize}" +
                $"\nArchiveFlags: {Flags}";

            return output;
        }

    }
}
