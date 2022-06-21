namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the player's exosuit.
    /// </summary>
    public interface IExosuit
    {
        /// <summary>
        /// Represents the player's suit refiner.
        /// </summary>
        public IRefiner SuitRefiner { get; protected set; }

        /// <summary>
        /// Returns the Exosuit's general inventory.
        /// </summary>
        /// <returns></returns>
        public IInventory GetInventory();

        /// <summary>
        /// Returns the Exosuit's technology inventory.
        /// </summary>
        /// <returns></returns>
        public IInventory GetTechnology();

        /// <summary>
        /// Returns the Exosuit's cargo inventory.
        /// </summary>
        /// <returns></returns>
        public IInventory GetCargo();
    }
}
