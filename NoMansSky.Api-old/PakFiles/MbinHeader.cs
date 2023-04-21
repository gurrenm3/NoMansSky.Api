using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Contains header info about MBIN files.
    /// <br/>Taken from https://github.com/cmkushnir/NMSModBuilder/blob/main/Common/NMS/PAK/Data/PAK.MBIN.Header.cs#L43
    /// </summary>
    internal class MbinHeader
    {
        public const int Size = 0x60;  // 96 bytes

        public const ulong MagicMbinc = 0x726576434e49424d;  // v1, "revCNIBM" ("MBINCver")
        public const uint MagicMbin = 0xcccccccc;          // *.MBIN
        public const uint MagicMbinPc = 0xdddddddd;          // *.MBIN.PC (TkGeometryData and TkGeometryStreamData)
        public const ushort FormatMbin = 2500;                // always

        public uint RawMagic { get; protected set; } = MagicMbin;
        public ushort RawFormatMbin { get; protected set; } = FormatMbin;
        public ushort RawFormatLib { get; protected set; } = 0;
        public ulong RawTimestamp { get; protected set; } = 0;
        public ulong RawGuid { get; protected set; } = 0;
        public byte[] RawName { get; protected set; } = new byte[64];
        public ulong RawPadding { get; protected set; } = 0;
        public string ClassName => Encoding.ASCII.GetString(RawName).TrimStart('c').TrimEnd('\0');


        public MbinHeader(Stream RAW)
        {
            if (RAW == null || RAW.Length < Size) return;

            RAW.Position = 0;
            var reader = new BinaryReader(RAW, Encoding.ASCII);

            RawMagic = reader.ReadUInt32();
            RawFormatMbin = reader.ReadUInt16();
            RawFormatLib = reader.ReadUInt16();
            RawTimestamp = reader.ReadUInt64();
            RawGuid = reader.ReadUInt64();
            RawName = reader.ReadBytes(64);

            RawPadding = reader.ReadUInt64();
        }
    }
}
