using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Spaceship global mbin file.
    /// <br/>The exact mbin type is GcSpaceshipGlobals.
    /// </summary>
    internal class SpaceshipGlobalFile : ISpaceshipGlobalFile
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
