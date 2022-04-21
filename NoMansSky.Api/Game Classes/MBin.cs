namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an MBIN file.
    /// </summary>
    public class MBin : IMBin
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Address { get; set; }
    }
}
