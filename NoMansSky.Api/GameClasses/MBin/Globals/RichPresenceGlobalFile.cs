using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Rich Presence global mbin file.
    /// <br/>The exact mbin type is GcRichPresenceGlobals.
    /// </summary>
    internal class RichPresenceGlobalFile : IRichPresenceGlobalFile
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
