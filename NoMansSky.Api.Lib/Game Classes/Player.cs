using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Local Player.
    /// </summary>
    public unsafe class Player
    {
        public enum StatType
        {
            Health,
            Shield,
            Units,
            Nanites,
            Quicksilver
        }

        /// <summary>
        /// The address of <see cref="GcPlayerStateData"/>.
        /// </summary>
        public long GcPlayerStateAddress => _gcPlayerStateAddress;
        private long _gcPlayerStateAddress;

        /// <summary>
        /// The base address of the actual player instance within the game.
        /// </summary>
        public long BaseAddress => _baseAddress;
        private long _baseAddress;

        /// <summary>
        /// Represents the player's Health.
        /// </summary>
        public Stat<int> Health { get; private set; } = new RealStat<int>();

        /// <summary>
        /// Represents the player's Shield.
        /// </summary>
        public Stat<int> Shield { get; private set; } = new RealStat<int>();

        /// <summary>
        /// Represents the player's Units.
        /// </summary>
        public Stat<int> Units { get; private set; } = new RealStat<int>();

        /// <summary>
        /// Represents the player's Nanites.
        /// </summary>
        public Stat<int> Nanites { get; private set; } = new RealStat<int>();

        /// <summary>
        /// Represents the player's Quicksilver.
        /// </summary>
        public Stat<int> Quicksilver { get; private set; } = new RealStat<int>();

        /// <summary>
        /// The player's current active ship.
        /// </summary>
        public Ship ActiveShip { get; set; }

        /// <summary>
        /// The player's exosuit.
        /// </summary>
        public Exosuit Exosuit { get; set; }

        /// <summary>
        /// Called when the pointer to GcPlayerStateData is aquired. This only called once when a profile
        /// is selected for the first time. Afterwords it is reused even if you go back to the Main Menu
        /// and switch to a different save.
        /// <br/>The parameter is the aquired pointer.
        /// </summary>
        public IModEvent<long> OnPlayerStateAquired { get; set; }

        /// <summary>
        /// Called when the pointer to the actual Player Instance has been aquired.
        /// </summary>
        public IModEvent<long> OnBaseAddressAquired { get; set; }


        private GcPlayerStateData* state;
        private bool initialized;

        public Player()
        {
            
        }

        /// <summary>
        /// Initializes this object It's called <see cref="Game.Instance"/> has finished initializing. Can only be called once.
        /// </summary>
        public static void Initialize()
        {
            var instance = Game.Instance.Player;
            if (instance.initialized)
                return;

            instance.OnPlayerStateAquired += instance.SetGcPlayerStateData;
            instance.OnBaseAddressAquired += (address) => instance._baseAddress = address;

            instance.Exosuit = new Exosuit();
            instance.ActiveShip = new Ship();

            instance.initialized = true;
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

            (Shield as RealStat<int>).Init(StatType.Shield.ToString(), address + 0xB0);
            (Health as RealStat<int>).Init(StatType.Health.ToString(), address + 0xB4);
            (Units as RealStat<int>).Init(StatType.Units.ToString(), address + 0xBC);
            (Nanites as RealStat<int>).Init(StatType.Nanites.ToString(), address + 0xC0);
            (Quicksilver as RealStat<int>).Init(StatType.Quicksilver.ToString(), address + 0xC4);
        }
    }
}
