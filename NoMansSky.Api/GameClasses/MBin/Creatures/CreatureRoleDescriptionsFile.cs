using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Creature Role Filename Table mbin file.
    /// <br/>The exact mbin type is GcCreatureRoleFilenameTable.
    /// </summary>
    internal class CreatureRoleDescriptionsFile : ICreatureRoleDescriptionsFile
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
