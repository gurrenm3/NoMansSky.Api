using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Creature Filename Table mbin file.
    /// <br/>The exact mbin type is GcCreatureFilenameTable.
    /// </summary>
    internal class CreatureFilenameFile : ICreatureFilenameFile
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
