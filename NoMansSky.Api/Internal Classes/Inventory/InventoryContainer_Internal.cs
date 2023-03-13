/*using Reloaded.ModHelper;
using System;
using System.Collections;

namespace NoMansSky.Api
{
    public unsafe class InventoryContainer_Internal : MbinClass, IInventoryContainer
    {
        public VirtualArray<int> UnlockedSlotsBitMask
        {
            get => GetValue<VirtualArray<int>>();
            set => TrySetValue<VirtualArray<int>>(value);
        }

        [FindOffset("44 0F BF 86 ? ? ? ? 45 3B D0 ", 4)]
        public short Width => GetValue<short>();


        [FindOffset("44 0F BF 8E ? ? ? ? 45 3B D9 ", 4)]
        public short Height => GetValue<short>();


        [FindOffset(searchPattern: "73 7A 48 8B BE ? ? ? ? ", numBytesToOffset: 5)]
        public VirtualList<LibMbin.GcInventoryElement> Slots
        {
            get => GetValue<VirtualList<LibMbin.GcInventoryElement>>();
            set => TrySetValue<VirtualList<LibMbin.GcInventoryElement>>(value);
        }


        public int MaxSlots => Width * Height;


        public InventoryContainer_Internal(long address) : base (address)
        {
            Slots.ElementOffset = 48;
            Slots.Count = () => MaxSlots;

            for (int i = 0; i < MaxSlots; i++)
            {
                Slots.Add(new LibMbin.GcInventoryElement(Slots.address + (i * 48)));
            }
        }


        public bool IsSlotUnlocked(LibMbin.GcInventoryElement item) => IsSlotUnlocked(item.Index.X, item.Index.Y);
        public bool IsSlotUnlocked(LibMbin.GcInventoryIndex index) => IsSlotUnlocked(index.X, index.Y);

        public bool IsSlotUnlocked(int x, int y)
        {
            if (x < 0 || x >= Width || Height < 0 || y >= Height)
                return false;

            var unlockedSlotsInRowAsBits = *(int*)(address + 8 * (y + x / 64));
            var bitIndex = x - (x & 64);
            BitArray bitArray = new BitArray(new int[] { unlockedSlotsInRowAsBits });
            return bitArray[bitIndex];
        }
    }
}
*/