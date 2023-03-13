using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Solar Generation global mbin file.
    /// <br/>The exact mbin type is GcSolarGenerationGlobals.
    /// </summary>
    internal class SolarGenerationGlobalFile : ISolarGenerationGlobalFile
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
