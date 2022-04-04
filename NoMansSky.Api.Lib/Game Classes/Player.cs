using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    public class Player
    {
        /// <summary>
        /// The player's current active ship.
        /// </summary>
        public Ship CurrentShip { get; set; } = new Ship();

        public GcPlayerStateData PlayerStateData { get; set; } = new GcPlayerStateData();

        /// <summary>
        /// Called whenever the value of the Player's health changes.
        /// <br/>The parameter is the amount that the health changed.
        /// </summary>
        public IModEventHook<int> OnHealthChanged { get; set; }

        /// <summary>
        /// Called whenever the value of the Player's shield changes.
        /// <br/>The parameter is the amount that the shield changed.
        /// </summary>
        public IModEventHook<float> OnShieldChanged { get; set; }
    }
}
