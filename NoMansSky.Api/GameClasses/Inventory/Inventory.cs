using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an inventory container.
    /// </summary>
    internal unsafe class Inventory : IInventory
    {
        OrderedList<IInventoryItem> itemsCache;
        private long address = 0;

        public Inventory()
        {
            itemsCache = new OrderedList<IInventoryItem>(new InventoryItemComparer());
        }

        /// <summary>
        /// Returns all of the items contained in the inventory
        /// </summary>
        /// <returns></returns>
        public OrderedList<IInventoryItem> GetItems()
        {
            if (address == 0)
                throw new Exception("Failed get inventory items. The address of this inventory was not set");

            itemsCache.Clear();
            const int nextItemOffset = 0x30; // Offset of 30 because there are 30 bytes between each item
            long nextItemAddress = address + nextItemOffset;

            int count = 0;
            while (true)
            {
                InventoryItem item = new InventoryItem();
                if (!item.InitFromAddress(nextItemAddress))
                    break;

                itemsCache.Add(item);
                nextItemAddress += nextItemOffset;
                count++;
            }

            return itemsCache;
        }

        /// <summary>
        /// Adds an item to this inventory.
        /// </summary>
        /// <param name="itemToAdd"></param>
        public void AddItem(IInventoryItem itemToAdd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an item from this inventory.
        /// </summary>
        /// <param name="itemToRemove"></param>
        public void RemoveItem(IInventoryItem itemToRemove)
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

        /// <summary>
        /// Returns all of the items in this inventory as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string title = string.Format("   {1,-22} | {2,-7} | {3,-7} | {4,-10}", "#", "ID", "Index", "Amount", "Max Amount");
            string titleUnderline = "".PadRight(title.Length, '-');

            string msg = $"{title}\n{titleUnderline}";
            var items = GetItems();
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                msg += string.Format("\n   {1,-22}   {2,-7}   {3,-7}   {4,-10}", i, item.ID, item.Index, item.Amount, item.MaxAmount);
            }

            msg += $"\n\n   Total Items: {items.Count}";

            return msg;
        }
    }
}