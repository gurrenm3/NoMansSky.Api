using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Creature Behavior mbin file.
    /// <br/>The exact mbin type is GcCreatureBehaviourTrees.
    /// </summary>
    internal class CreatureBehaviorFile : ICreatureBehaviorFile
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
