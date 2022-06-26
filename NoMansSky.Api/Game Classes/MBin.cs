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
        public string Name { get; init; } = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Address { get; init; }
    }
}
