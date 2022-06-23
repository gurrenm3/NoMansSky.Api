using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the Local Player.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Reflects whether or not GcPlayerStateData has been initialized.
        /// </summary>
        public bool HasGcPlayerState { get; }

        /// <summary>
        /// The address of the current instance of <see cref="GcPlayerStateData"/>.
        /// </summary>
        public long GcPlayerStateAddress { get; }

        /// <summary>
        /// The base address of the actual player instance within the game.
        /// </summary>
        public long BaseAddress { get; }

        /// <summary>
        /// Represents the player's Health.
        /// </summary>
        public Stat<int> Health { get; }

        /// <summary>
        /// Represents the player's Shield.
        /// </summary>
        public Stat<int> Shield { get; }

        /// <summary>
        /// Represents the player's Units.
        /// </summary>
        public Stat<int> Units { get; }

        /// <summary>
        /// Represents the player's Nanites.
        /// </summary>
        public Stat<int> Nanites { get; }

        /// <summary>
        /// Represents the player's Quicksilver.
        /// </summary>
        public Stat<int> Quicksilver { get; }

        /// <summary>
        /// Represents the player's current active ship.
        /// </summary>
        public IShip Ship { get; }

        /// <summary>
        /// Represents the player's exosuit.
        /// </summary>
        public IExosuit Exosuit { get; }

        /// <summary>
        /// Represents the MultiTool currently being used by the player.
        /// </summary>
        public IMultiTool ActiveMultiTool { get; }


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
    }
}
