using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Discovery Reward Lookup Table mbin.
    /// <br/>The exact mbin type is GcDiscoveryRewardLookupTable.
    /// </summary>
    internal class DiscoveryRewardsFile : IDiscoveryRewardsFile
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
