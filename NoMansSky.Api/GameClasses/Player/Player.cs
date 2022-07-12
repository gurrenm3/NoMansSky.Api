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
        public long GcPlayerStateAddress => _gcPlayerStateAddress;
        private long _gcPlayerStateAddress;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long BaseAddress => _baseAddress;
        private long _baseAddress;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool HasGcPlayerState => GcPlayerStateAddress != 0;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Stat<int> Health { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Stat<int> Shield { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Stat<int> Units { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Stat<int> Nanites { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Stat<int> Quicksilver { get; private set; } 

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IShip Ship => _activeShip;
        private IShip _activeShip = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IExosuit Exosuit => _exosuit;
        private IExosuit _exosuit = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMultiTool ActiveMultiTool => _multiTool;
        private IMultiTool _multiTool = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IInventoryStoreBalance DefaultInventoryBalance { get; } = new InventoryStoreBalance();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<long> OnPlayerStateAquired { get; set; } = new SharedModEvent<long>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<long> OnBaseAddressAquired { get; set; } = new SharedModEvent<long>();

        private GcPlayerStateData* state;
        private bool isInitialized;
        private IModLogger logger;
        private bool badHealthError; // represents setting health to bad value during loading.
        private int healthBeforeError;

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

            OnPlayerStateAquired += SetGcPlayerStateData;
            OnBaseAddressAquired += (address) => _baseAddress = address;

            Health = new RealStat<int>();
            Shield = new RealStat<int>();
            Units = new RealStat<int>();
            Nanites = new RealStat<int>();
            Quicksilver = new RealStat<int>();

            Health.OnValueChanged = new SharedModEventHook<int>();
            InitBadHealthError();

            Shield.OnValueChanged = new SharedModEventHook<int>();
            Units.OnValueChanged = new SharedModEventHook<int>();
            Nanites.OnValueChanged = new SharedModEventHook<int>();
            Quicksilver.OnValueChanged = new SharedModEventHook<int>();

            _exosuit = new Exosuit(logger);
            _multiTool = new MultiTool();
            _activeShip = new Ship();

            isInitialized = true;
        }

        /// <summary>
        /// Set's the address of the PlayerStateData and populates it.
        /// <br/>This method is used by the API to prepare the game data.
        /// <br/>Calling this method will negatively affect the game and might break your mods.
        /// </summary>
        /// <param name="address"></param>
        private unsafe void SetGcPlayerStateData(long address)
        {
            _gcPlayerStateAddress = address;
            if (_gcPlayerStateAddress == 0)
                return;

            state = (GcPlayerStateData*) _gcPlayerStateAddress;

            (Shield as RealStat<int>)?.Init("Shield", address + 0x1B0);
            (Health as RealStat<int>)?.Init("Health", address + 0x1B4);
            (Units as RealStat<int>)?.Init("Units", address + 0x1BC);
            (Nanites as RealStat<int>)?.Init("Nanites", address + 0x1C0);
            (Quicksilver as RealStat<int>)?.Init("Quicksilver", address + 0x1C4);
        }

        /// <summary>
        /// Represents the error when the health is set to zero or below before loading into the game.
        /// This would cause the player to die before loading into the game and would be bad, therefore it should be 
        /// protected against.
        /// </summary>
        private void InitBadHealthError()
        {
            Health.OnValueChanged.Prefix += (newValue) =>
            {
                badHealthError = false;
                if (!Game.Instance.IsInGame && newValue <= 0)
                {
                    logger.WriteLine($"Tried setting Player Health to {newValue} before the game has loaded." +
                        $" This is not allowed since it would cause the player to die before even loading into the game." +
                        $" Health will therefore not change.", LogLevel.Error);
                    newValue.value = Health.Value;
                    badHealthError = true;
                    healthBeforeError = Health.Value;
                }
            };
            Health.OnValueChanged.Postfix += (newValue) =>
            {
                if (badHealthError)
                    Health.Value = healthBeforeError;
            };
        }
    }
}
