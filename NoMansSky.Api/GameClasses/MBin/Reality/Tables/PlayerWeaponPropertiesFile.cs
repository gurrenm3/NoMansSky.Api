using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Player Weapon Properties Table mbin.
    /// <br/>The exact mbin type is GcPlayerWeaponPropertiesTable.
    /// </summary>
    internal class PlayerWeaponPropertiesFile : IPlayerWeaponPropertiesFile
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
