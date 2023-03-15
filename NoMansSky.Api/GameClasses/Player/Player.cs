using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Local Player.
    /// </summary>
    internal unsafe class Player : IPlayer
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Pointer { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<long> OnPointerAquired { get; set; } = new SharedModEvent<long>();

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
