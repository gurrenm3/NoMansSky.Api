namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a single file entry in a Pak File.
    /// <br/>Thanks to cmkushnir#4490 for all their help making this.
    /// <br/>Code is heavily based off of https://github.com/cmkushnir/NMSModBuilder/tree/main/Common/NMS/PAK
    /// </summary>
    public class PakFileEntry
    {
        /// <summary>
        /// 128-bit md5 hash 
        /// </summary>
        public string NameDigest { get; set; }

        /// <summary>
        /// Offset in block list. 
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Size of this entry once uncompressed.
        /// </summary>
        public long UncompressedSize { get; set; }

        /// <summary>
        /// Byte offset in psarc for this entry. 
        /// </summary>
        public long FileOffset { get; set; }

        /// <summary>
        /// The internal file path of this file entry.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// The Mbin type, if it exists.
        /// </summary>
        public string MbinType { get; set; }

        /// <summary>
        /// Creates the file entry.
        /// </summary>
        /// <param name="nameDigest"></param>
        /// <param name="blockOffset"></param>
        /// <param name="uncompressedSize"></param>
        /// <param name="fileOffset"></param>
        public PakFileEntry(string nameDigest, int blockOffset, long uncompressedSize, long fileOffset)
        {
            NameDigest = nameDigest;
            Index = blockOffset;
            UncompressedSize = uncompressedSize;
            FileOffset = fileOffset;
        }
    }
}
