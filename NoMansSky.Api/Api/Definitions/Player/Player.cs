using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Local Player.
    /// </summary>
    internal unsafe class Player : IPlayer
    {
        /// <summary>
        /// Instance to GcPlayer.
        /// </summary>
        public long GcPlayerPtr { get; set; }

        /// <summary>
        /// Instance to GcPlayerState.
        /// </summary>
        public long GcPlayerStatePtr { get; set; }

        /// <summary>
        /// Called when GcPlayerPtr is acquired.
        /// </summary>
        public IModEvent OnGcPlayerAquired { get; set; } = new SharedModEvent();

        /// <summary>
        /// Called when GcPlayerStatePtr is acquired.
        /// </summary>
        public IModEvent OnGcPlayerStateAquired { get; set; } = new SharedModEvent();

        private bool isInitialized;
        private IModLogger logger;

        /// <summary>
        /// Creates an instance of this class and provides a logger for logging important messages.
        /// </summary>
        /// <param name="apiLogger"></param>
        public Player(IModLogger apiLogger)
        {
            logger = apiLogger;
        }

        internal void Init()
        {
            if (isInitialized)
                return;

            isInitialized = true;
        }
    }
}
