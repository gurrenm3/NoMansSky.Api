using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Creature Generation Archetypes mbin file.
    /// <br/>The exact mbin type is GcCreatureGenerationArchetypes.
    /// </summary>
    internal class CreatureGenArchetypesFile : ICreatureGenArchetypesFile
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
