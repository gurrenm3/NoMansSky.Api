namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an MBIN file.
    /// </summary>
    public interface IMBin
    {
        /// <summary>
        /// The name of this MBIN File.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The address to the instance of this MBIN file.
        /// </summary>
        public long Address { get; set; }
    }
}
