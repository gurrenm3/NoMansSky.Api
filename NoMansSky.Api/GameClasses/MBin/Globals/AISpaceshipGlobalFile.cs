using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the AI Spaceship global mbin file.
    /// <br/>The exact mbin type is GcAISpaceshipGlobals.
    /// </summary>
    internal class AISpaceshipGlobalFile : IAISpaceshipGlobalFile
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
