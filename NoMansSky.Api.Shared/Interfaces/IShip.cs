using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the player's ship.
    /// </summary>
    public interface IShip
    {
        /// <summary>
        /// Called whenever the value of the Ship's health changes.
        /// <br/>The parameter is the amount that the health changed.
        /// </summary>
        public IModEventHook<int> OnHealthChanged { get; set; }

        /// <summary>
        /// Called whenever the value of the Ship's shield changes.
        /// <br/>The parameter is the amount that the shield changed.
        /// </summary>
        public IModEventHook<int> OnShieldChanged { get; set; }
    }
}
