using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an Unlockable Twitch Rewards mbin.
    /// <br/>The exact mbin type is GcUnlockableTwitchRewards.
    /// </summary>
    internal class UnlockableTwitchRewards : IUnlockableTwitchRewards
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
