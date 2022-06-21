using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an inventory container.
    /// </summary>
    public interface IInventory
    {
        /// <summary>
        /// Returns a list containing all of the items currently in the inventory.
        /// </summary>
        /// <returns></returns>
        public OrderedList<IInventoryItem> GetItems();

        /// <summary>
        /// Add an item to this inventory.
        /// </summary>
        /// <param name="itemToAdd"></param>
        public void AddItem(IInventoryItem itemToAdd);

        /// <summary>
        /// Remove an item from this inventory.
        /// </summary>
        /// <param name="itemToRemove"></param>
        public void RemoveItem(IInventoryItem itemToRemove);
    }
}
