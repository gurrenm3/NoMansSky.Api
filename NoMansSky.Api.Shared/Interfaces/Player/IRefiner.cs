namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a Refiner that can refine items into other items.
    /// </summary>
    public interface IRefiner
    {
        /// <summary>
        /// Address to this refiner.
        /// </summary>
        public long Address { get; }

        /// <summary>
        /// Represents the fuel of the refiner.
        /// </summary>
        public InventoryItem Fuel { get; set; }
        
        /// <summary>
        /// Represents the item to be refined.
        /// </summary>
        public InventoryItem Input { get; set; }

        /// <summary>
        /// Represents the newly refined item.
        /// </summary>
        public InventoryItem Output { get; set; }
    }
}
