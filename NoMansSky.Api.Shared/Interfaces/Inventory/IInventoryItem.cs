namespace NoMansSky.Api
{
    /// <summary>
    /// Represents one inventory item.
    /// </summary>
    public interface IInventoryItem
    {
        /// <summary>
        /// The location of this item within it's inventory.
        /// </summary>
        public GcInventoryIndex_old Index { get; set; }

        /// <summary>
        /// The type of this item.
        /// </summary>
        //public GcInventoryType ItemType { get; set; } // removed for now

        /// <summary>
        /// The ID of this item.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The amount of this item in this stack.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// The maximum amount this item can contain.
        /// </summary>
        public int MaxAmount { get; set; }
    }
}
