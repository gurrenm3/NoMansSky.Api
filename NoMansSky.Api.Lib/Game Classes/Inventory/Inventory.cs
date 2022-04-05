using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an inventory container.
    /// </summary>
    public unsafe class Inventory
    {
        private long address;

        public Inventory()
        {

        }

        /// <summary>
        /// Returns the number of items in the inventory.
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all of the items contained in the inventory
        /// </summary>
        /// <returns></returns>
        public InventoryItem[] GetItems()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds an item to this inventory.
        /// </summary>
        /// <param name="itemToAdd"></param>
        public void AddItem(InventoryItem itemToAdd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an item from this inventory.
        /// </summary>
        /// <param name="itemToRemove"></param>
        public void RemoveItem(InventoryItem itemToRemove)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes this inventory starting from an address.
        /// </summary>
        /// <param name="address"></param>
        public void InitFromAddress(long address)
        {
            this.address = address;
            throw new NotImplementedException();
        }
    }
}
