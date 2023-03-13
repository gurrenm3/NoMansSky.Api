using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Smoke Test Options mbin file.
    /// <br/>The exact mbin type is GcSmokeTestOptions.
    /// </summary>
    internal class SmokeTestOptionsFile : ISmokeTestOptionsFile
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
