using System;

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
        public string Name { get; init; }

        /// <summary>
        /// The address to the instance of this MBIN file.
        /// </summary>
        public long Address { get; init; }

        /// <summary>
        /// The libMbin type for this mbin file.
        /// </summary>
        public Type MBinType { get; init; }
    }
}
