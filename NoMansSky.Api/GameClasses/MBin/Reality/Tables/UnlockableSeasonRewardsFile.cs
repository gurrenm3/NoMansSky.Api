using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an Unlockable Season Rewards mbin.
    /// <br/>The exact mbin type is GcUnlockableSeasonRewards.
    /// </summary>
    internal class UnlockableSeasonRewardsFile : IUnlockableSeasonRewardsFile
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
