using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Pet Egg Trait Modifier Override Table mbin file.
    /// <br/>The exact mbin type is GcPetEggTraitModifierOverrideTable.
    /// </summary>
    internal class PetEggTraitModifierFile : IPetEggTraitModifierFile
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
