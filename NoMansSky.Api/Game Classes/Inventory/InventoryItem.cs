using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents one inventory item.
    /// </summary>
    public unsafe class InventoryItem : IInventoryItem
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public GcInventoryIndex Index
        {
            get { return item->index; }
            set { item->index = value; }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public GcInventoryType ItemType
        {
            get { return item->itemType; }
            set { item->itemType = value; }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string ID
        {
            get { return GetItemId(); }
            set { SetItemId(value); }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public int Amount
        {
            get { return item->amount; }
            set { item->amount = value; }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public int MaxAmount
        {
            get { return item->maxAmount; }
            set { item->maxAmount = value; }
        }


        /// <summary>
        /// The address of the <see cref="GcInventoryElement"/> that corresponds to this item.
        /// </summary>
        public long Address => address;

        private GcInventoryElement* item;
        private long address;

        public InventoryItem()
        {

        }

        public InventoryItem(long address)
        {
            InitFromAddress(address);
        }

        

        /// <summary>
        /// Initializes this item from an address.
        /// </summary>
        /// <param name="address"></param>
        /// <returns>Wil return true if successful, otherwise false.</returns>
        public bool InitFromAddress(long address)
        {
            if (address == 0)
            {
                return false;
            }

            this.address = address;
            /*var test = Marshal.PtrToStructure<GcInventoryElement>((IntPtr)address);
            item = &test;*/

            item = (GcInventoryElement*)address;
            //Console.WriteLine((long)item->id);

            /*var valueAddress = *(long*)item->id->value;
            Console.WriteLine(valueAddress);*/
            /*var originalId = (char*)(address + 0x8);
            var orig = Strings.ToString(originalId);*/

            return IsItemValid();
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        private bool IsItemValid()
        {
            bool isNameValid = !string.IsNullOrEmpty(ID);
            bool isTypeValid = (int)ItemType <= 2 && ItemType >= 0;
            return isNameValid && isTypeValid;
        }

        /// <summary>
        /// Returns the type of this item.
        /// </summary>
        /// <returns></returns>
        public GcInventoryType GetItemType()
        {
            return item->itemType;
        }

        /// <summary>
        /// Set's the type of this item.
        /// </summary>
        /// <param name="newType"></param>
        public void SetItemType(GcInventoryType newType)
        {
            item->itemType = newType;
        }

        /// <summary>
        /// Returns the ID of this item.
        /// </summary>
        /// <returns></returns>
        public string GetItemId()
        {
            var idAddress = (decimal*)(address + 0x8);
            return Strings.ToString(idAddress);
        }

        public void SetItemId(string newId)
        {
            throw new NotImplementedException();
            
            // this attempt was to try to get convert the newId to Hex, then from Hex to Decimal, and finally setting
            // item->id to that value. Not currenty working reliably.

            /*string flipped = newId.ReverseString();
            string hexStr = flipped.ToHex(false, true);
            var hexSplit = hexStr.Split(' ');

            decimal result = 0;
            foreach (var item in hexSplit)
            {
                var hexNumber = Int32.Parse(item, System.Globalization.NumberStyles.HexNumber);
                result = 256 * result + hexNumber;
            }*/
        }

        /// <summary>
        /// Returns the quantity of this item.
        /// </summary>
        /// <returns></returns>
        public int GetQuantity()
        {
            return item->amount;
        }

        /// <summary>
        /// Set's the quantity of this item.
        /// </summary>
        /// <param name="newQuantity"></param>
        public void SetQuantity(int newQuantity)
        {
            item->amount = newQuantity;
        }

        /// <summary>
        /// Returns the maximum possible quantity of this item.
        /// </summary>
        /// <returns></returns>
        public int GetMaxQuantity()
        {
            return item->maxAmount;
        }

        /// <summary>
        /// Set's the maximum possible quantity for this item.
        /// </summary>
        /// <param name="newMaxQuantity"></param>
        public void SetMaxQuantity(int newMaxQuantity)
        {
            item->maxAmount = newMaxQuantity;
        }
    }
}
