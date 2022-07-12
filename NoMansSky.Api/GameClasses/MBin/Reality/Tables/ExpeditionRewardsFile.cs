using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Expedition Reward Table mbin.
    /// <br/>The exact mbin type is GcExpeditionRewardTable.
    /// </summary>
    internal class ExpeditionRewardsFile : IExpeditionRewardsFile
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
