using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an Alien Puzzles Table mbin.
    /// <br/>The exact mbin type is GcAlienPuzzleTable.
    /// </summary>
    internal class AlienPuzzlesFile : IAlienPuzzlesFile
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
