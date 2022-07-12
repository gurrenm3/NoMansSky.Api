using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Settlement Perks Table mbin.
    /// <br/>The exact mbin type is GcSettlementPerksTable.
    /// </summary>
    internal class SettlementPerksFile : ISettlementPerksFile
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
