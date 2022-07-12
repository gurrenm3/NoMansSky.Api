using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Player Damage Table mbin.
    /// <br/>The exact mbin type is GcPlayerDamageTable.
    /// </summary>
    internal class PlayerDamageFile : IPlayerDamageFile
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
