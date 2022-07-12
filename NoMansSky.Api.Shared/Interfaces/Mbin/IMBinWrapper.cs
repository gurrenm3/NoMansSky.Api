using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the wrapper class used to handle mbins.
    /// </summary>
    public interface IMBinWrapper
    {
        /// <summary>
        /// Called when this mbin file is loaded.
        /// </summary>
        public IModEvent OnLoaded { get; set; }

        /// <summary>
        /// The MBin file for this object
        /// </summary>
        public IMBin MBin { get; set; }
    }
}
