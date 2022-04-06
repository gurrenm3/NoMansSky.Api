using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an inventory container.
    /// </summary>
    public unsafe class Inventory
    {
        private long address = 0;

        public Inventory()
        {

        }

        /// <summary>
        /// Returns all of the items contained in the inventory
        /// </summary>
        /// <returns></returns>
        public List<InventoryItem> GetItems()
        {
            List<InventoryItem> items = new List<InventoryItem>();

            const int offsetToNextItem = 0x30; // Offset of 30 because there are 30 bytes between each item
            long nextItemAddress = address;

            int count = 0;
            while (true)
            {
                InventoryItem item = new InventoryItem();
                if (!item.InitFromAddress(nextItemAddress))
                    break;

                items.Add(item);
                nextItemAddress += offsetToNextItem;
                count++;
            }

            return items;
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
        }
    }
}
