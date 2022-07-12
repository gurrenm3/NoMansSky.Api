using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Creature Description mbin file.
    /// <br/>The exact mbin type is GcCreatureRoleDescriptionTable.
    /// </summary>
    internal class CreatureDescriptionFile : ICreatureDescriptionFile
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
