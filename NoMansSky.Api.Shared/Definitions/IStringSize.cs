namespace NoMansSky.Api.Definitions
{
    /// <summary>
    /// Used to specify the max length of a virtual string.
    /// </summary>
    public interface IStringSize
    {
        /// <summary>
        /// The maximum length a virtual string can be.
        /// </summary>
        int MaxLength { get; }

        /// <summary>
        /// Number of bytes to align text by.
        /// </summary>
        int Alignment { get; }
    }
}
