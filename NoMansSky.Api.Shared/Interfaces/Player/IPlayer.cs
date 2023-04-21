using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Local Player.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Pointer to GcPlayer.
        /// </summary>
        public long GcPlayerPtr { get; set; }

        /// <summary>
        /// Pointer to GcPlayerState.
        /// </summary>
        public long GcPlayerStatePtr { get; set; }

        /// <summary>
        /// Called when GcPlayerPtr is acquired.
        /// </summary>
        public IModEvent OnGcPlayerAquired { get; set; }

        /// <summary>
        /// Called when GcPlayerStatePtr is acquired.
        /// </summary>
        public IModEvent OnGcPlayerStateAquired { get; set; }
    }
}
