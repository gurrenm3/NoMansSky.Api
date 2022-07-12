using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Creature Pet Behavior Table mbin file.
    /// <br/>The exact mbin type is GcPetBehaviourTable.
    /// </summary>
    internal class PetBehaviorFile : IPetBehaviorFile
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
