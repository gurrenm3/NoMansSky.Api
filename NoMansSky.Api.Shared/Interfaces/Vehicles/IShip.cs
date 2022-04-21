using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the player's ship.
    /// </summary>
    public interface IShip
    {
        /// <summary>
        /// The Health stat of the ship.
        /// </summary>
        public Stat<int> Health { get; set; }

        /// <summary>
        /// TODO: The Shield stat of the ship.
        /// </summary>
        public Stat<int> Shield { get; set; }
    }
}
