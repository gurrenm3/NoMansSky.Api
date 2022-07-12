using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Pet Egg Species Override Table mbin file.
    /// <br/>The exact mbin type is GcPetEggSpeciesOverrideTable.
    /// </summary>
    internal class PetEggSpeciesOverrideFile : IPetEggSpeciesOverrideFile
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
