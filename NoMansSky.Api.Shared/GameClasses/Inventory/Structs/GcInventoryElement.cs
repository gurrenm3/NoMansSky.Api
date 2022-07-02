using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the actual data for an item within the inventory.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct GcInventoryElement
    {
        /*[FieldOffset(0x0)]
        public GcInventoryType itemType;*/

        /// <summary>
        /// The ID of this item. Identifies what item it is.
        /// <br/><br/>Doesn't work well, I'm having issues getting this to work.
        /// </summary>
        [FieldOffset(0x8)]
        public decimal id;

        /// <summary>
        /// The current amount of this item.
        /// </summary>
        [FieldOffset(0x18)]
        public int amount;

        /// <summary>
        /// The max possible amount this item can have.
        /// </summary>
        [FieldOffset(0x1C)]
        public int maxAmount;

        /// <summary>
        /// The location of this item within the inventory.
        /// </summary>
        [FieldOffset(0x28)]
        public GcInventoryIndex index;
    }

}
