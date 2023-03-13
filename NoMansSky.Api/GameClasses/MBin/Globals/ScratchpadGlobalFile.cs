using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Scratchpad global mbin file.
    /// <br/>The exact mbin type is GcScratchpadGlobals.
    /// </summary>
    internal class ScratchpadGlobalFile : IScratchpadGlobalFile
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnLoaded { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMBin MBin { get; set; }
    }
}
