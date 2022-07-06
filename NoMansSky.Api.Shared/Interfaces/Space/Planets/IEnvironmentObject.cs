namespace NoMansSky.Api
{
    /// <summary>
    /// Links a Biome MBin File/Environment Object with it's address in memory.
    /// </summary>
    public interface IEnvironmentObject
    {
        /// <summary>
        /// The name of this Biome's MBin file.
        /// </summary>
        public string MBinName { get; set; }

        /// <summary>
        /// The address of this Biome MBin file loaded in memory.
        /// </summary>
        public long Address { get; set; }
    }
}
