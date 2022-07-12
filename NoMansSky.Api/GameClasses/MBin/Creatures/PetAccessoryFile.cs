using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Creature Pet Accessory mbin file.
    /// <br/>The exact mbin type is GcPetAccessoryTable.
    /// </summary>
    internal class PetAccessoryFile : IPetAccessoryFile
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
