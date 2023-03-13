using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Gameplay global mbin file.
    /// <br/>The exact mbin type is GcGameplayGlobals.
    /// </summary>
    internal class GameplayGlobalFile : IGameplayGlobalFile
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
