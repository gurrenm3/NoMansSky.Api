using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an Alien Speech Table mbin.
    /// <br/>The exact mbin type is GcAlienSpeechTable.
    /// </summary>
    internal class AlienSpeechFile : IAlienSpeechFile
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
