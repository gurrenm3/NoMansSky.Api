namespace NoMansSky.Api
{
    /// <summary>
    /// The type of compression used for this PSArc file.
    /// <br/>Documentation taken from here: https://www.psdevwiki.com/ps3/PlayStation_archive_(PSARC)#Description
    /// </summary>
    public enum CompressionType
    {
        /// <summary>
        /// The default compression type for PSArc files.
        /// </summary>
        Zlib,

        /// <summary>
        /// Lzma compression type.
        /// </summary>
        Lzma
    }
}
