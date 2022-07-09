using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an MBIN file.
    /// </summary>
    public interface IMBin
    {
        /// <summary>
        /// Reflects whether or not this mbin was already initialized.
        /// </summary>
        public bool IsInitialized { get; }

        /// <summary>
        /// The name of this MBIN File.
        /// </summary>
        public string MBinName { get; }

        /// <summary>
        /// The full name of this mbin. Contains the name of this MBin and it's full path.
        /// </summary>
        public string FullName { get;  }

        /// <summary>
        /// The address to the instance of this MBIN file.
        /// </summary>
        public long Address { get; }

        /// <summary>
        /// The libMbin type for this mbin file.
        /// </summary>
        public Type MBinType { get; }

        /// <summary>
        /// Used to initialize this mbin file.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="fullName"></param>
        public bool Init(string fullName, long address, bool initializeOnce = true);
    }
}
