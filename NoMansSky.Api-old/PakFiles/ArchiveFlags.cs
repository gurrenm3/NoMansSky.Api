namespace NoMansSky.Api
{
    /// <summary>
    /// 
    /// <br/>Documentation taken from here: https://www.psdevwiki.com/ps3/PlayStation_archive_(PSARC)#Description
    /// </summary>
    public enum ArchiveFlags
    {
        /// <summary>
        /// Default for .psarc files.
        /// <br/>The paths in the manifest don't have an slash character at the start of every line,
        /// the system accesses the files exactly like if the .psarc was a folder itself
        /// <br/><br/>Example: Folder/File.bin
        /// </summary>
        Relative,

        /// <summary>
        /// Indicates that the paths in the PSArc Manifest are case insensitive.
        /// </summary>
        IgnoreCase,

        /// <summary>
        /// The paths in the manifest have an slash character at the start of every line.
        /// <br/><br/>Example: /Folder/File.bin
        /// </summary>
        Absolute
    }
}
