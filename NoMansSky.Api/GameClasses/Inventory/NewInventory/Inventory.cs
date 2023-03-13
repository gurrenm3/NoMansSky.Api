/*using NoMansSky.Api.LibMbin;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoMansSky.Api.GameClasses.Inventory.NewInventory;

public class Inventory : MbinClass
{
    [FindOffset("44 0F BF 86 ? ? ? ? 45 3B D0 ", 4)]
    private short Width => GetValue<short>();


    [FindOffset("44 0F BF 8E ? ? ? ? 45 3B D9 ", 4)]
    private short Height => GetValue<short>();

    
    [FindOffset(searchPattern: "73 7A 48 8B BE ? ? ? ? ", numBytesToOffset: 5)]
    private long AddressToUsedSlots => GetValue<long>();

    VirtualArray<long> unlockedSlotsBitMask;

    public Inventory(long address) : base(address)
    {
        unlockedSlotsBitMask = new VirtualArray<long>(address, arraySize: GetHeight(), elementSize: 8);
    }

    //////////////////////
    // ideas for methods:
    //////////////////////
    //
    // Get all slots with item
    // Does any slot contain item
    // lock / unlock a slot
    // resize inventory
    // swap items between slots
    // Add item
    // remove item
    // Get total count of item
    // Sort
    // Merge duplicates
    // Swap Inventories


    /// <summary>
    /// Returns the maximum width of this inventory.
    /// </summary>
    /// <returns></returns>
    public int GetHeight() => Height;

    /// <summary>
    /// Returns the maximum height of this inventory.
    /// </summary>
    /// <returns></returns>
    public int GetWidth() => Width;

    /// <summary>
    /// Returns the maximum possible capacity for this inventory. 
    /// <br/>Note, this includes slots that aren't unlocked yet.
    /// </summary>
    /// <returns></returns>
    public int GetMaxCapacity() => Width * Height;

    /// <summary>
    /// Returns all slots that are unlocked regardless of whether or not they are in use.
    /// </summary>
    /// <returns></returns>
    public unsafe List<InventorySlot> GetSlots() => GetSlots(InventorySlotType.Unlocked, InventorySlotType.InUse, InventorySlotType.NotInUse);

    /// <summary>
    /// Returns the slots in this inventory.
    /// </summary>
    /// <returns></returns>
    public unsafe List<InventorySlot> GetSlots(params InventorySlotType[] slotsToGet)
    {
        int sizeOfItem = libMBIN.NMSTemplate.SizeOf(typeof(libMBIN.NMS.GameComponents.GcInventoryElement));
        var addressToSlots = *(long*)(address + GetOffset(nameof(AddressToUsedSlots)));

        int maxCapacity = GetMaxCapacity();
        int width = GetWidth();
        var usedIndexes = GetUsedIndecies();

        // using a dictionary to easily keep track of which ones we want/don't want.
        Dictionary<InventorySlotType, bool> slotsToSearchFor = new();
        foreach (var item in Enum.GetValues<InventorySlotType>())
            slotsToSearchFor.Add(item, slotsToGet.Contains(item));


        List<InventorySlot> slots = new List<InventorySlot>();
        for (int i = 0; i < maxCapacity; i++)
        {
            var xPos = i % width;
            var yPos = i / width;

            // add it automatically if we want all slots.
            if (slotsToSearchFor[InventorySlotType.All])
            {
                slots.Add(CreateSlot(xPos, yPos, IsSlotInUse(xPos, yPos, usedIndexes)));
                continue;
            }

            // if slot is locked and we're not looking for locked slots.
            // Or if slot is unlocked but we're not looking for unlocked slots.
            bool isUnlocked = IsSlotUnlocked(xPos, yPos);
            if (!isUnlocked && !slotsToSearchFor[InventorySlotType.Locked] || isUnlocked && !slotsToSearchFor[InventorySlotType.Unlocked])
                continue;

            // if the slot is in use and we're not looking for in use slots.
            // Or if the slot is not in use but we're not looking for "NotInUse" slots.
            bool isInUse = IsSlotInUse(xPos, yPos, usedIndexes);
            if (isInUse && !slotsToSearchFor[InventorySlotType.InUse] || !isInUse && !slotsToSearchFor[InventorySlotType.NotInUse])
                continue;

            slots.Add(CreateSlot(xPos, yPos, isInUse));
        }

        return slots;
    }











    public unsafe List<InventorySlot> GetSlotsParallel() => GetSlotsParallel(InventorySlotType.Unlocked, InventorySlotType.InUse, InventorySlotType.NotInUse);

    /// <summary>
    /// Returns the slots in this inventory.
    /// </summary>
    /// <returns></returns>
    public unsafe List<InventorySlot> GetSlotsParallel(params InventorySlotType[] slotsToGet)
    {
        int sizeOfItem = libMBIN.NMSTemplate.SizeOf(typeof(libMBIN.NMS.GameComponents.GcInventoryElement));
        var addressToSlots = *(long*)(address + GetOffset(nameof(AddressToUsedSlots)));

        int maxCapacity = GetMaxCapacity();
        int width = GetWidth();
        var usedIndexes = GetUsedIndecies();

        // using a dictionary to easily keep track of which ones we want/don't want.
        Dictionary<InventorySlotType, bool> slotsToSearchFor = new();
        foreach (var item in Enum.GetValues<InventorySlotType>())
            slotsToSearchFor.Add(item, slotsToGet.Contains(item));


        List<InventorySlot> slots = new List<InventorySlot>();
        Parallel.For(0, maxCapacity, i =>
        {
            var xPos = i % width;
            var yPos = i / width;

            // add it automatically if we want all slots.
            if (slotsToSearchFor[InventorySlotType.All])
            {
                slots.Add(CreateSlot(xPos, yPos, IsSlotInUse(xPos, yPos, usedIndexes)));
                return;
            }

            // if slot is locked and we're not looking for locked slots.
            // Or if slot is unlocked but we're not looking for unlocked slots.
            bool isUnlocked = IsSlotUnlocked(xPos, yPos);
            if (!isUnlocked && !slotsToSearchFor[InventorySlotType.Locked] || isUnlocked && !slotsToSearchFor[InventorySlotType.Unlocked])
                return;

            // if the slot is in use and we're not looking for in use slots.
            // Or if the slot is not in use but we're not looking for "NotInUse" slots.
            bool isInUse = IsSlotInUse(xPos, yPos, usedIndexes);
            if (isInUse && !slotsToSearchFor[InventorySlotType.InUse] || !isInUse && !slotsToSearchFor[InventorySlotType.NotInUse])
                return;

            slots.Add(CreateSlot(xPos, yPos, isInUse));
        });

        return slots;
    }




















    private InventorySlot CreateSlot(int xPos, int yPos, bool isInUse)
    {
        var slot = new InventorySlot(this) { X = xPos, Y = yPos };

        if (isInUse)
        {
            var element = GetElementAtPosition(xPos, yPos);
            if (element == null)
                return slot;

            var item = new InventoryItem(element);
            slot.SetItem(item);
        }

        return slot;
    }

    private unsafe GcInventoryElement GetElementAtPosition(int xPos, int yPos)
    {
        var addressToSlots = address + GetOffset(nameof(AddressToUsedSlots));
        var currentItem = *(long*)addressToSlots;
        var nextInventory_Maybe = *(long*)(addressToSlots + 0x8);

        do
        {
            int x = *(int*)(currentItem + 40);
            int y = *(int*)(currentItem + 44);

            if (x == xPos && y == yPos)
                return new GcInventoryElement(currentItem);

            currentItem += 48;

        } while (currentItem < nextInventory_Maybe);

        return null;
    }

    /// <summary>
    /// Returns whether or not the slot at the provided X, Y coordinate is unlocked.
    /// </summary>
    /// <param name="x">zero based x position of the slot.</param>
    /// <param name="y">zero based y position of the slot.</param>
    /// <returns></returns>
    public unsafe bool IsSlotUnlocked(int x, int y)
    {
        // switch this to use the bitmask above.

        //var bits = *(int*)(address + 8 * y);
        var bits = unlockedSlotsBitMask[y];
        return Convert.ToBoolean((bits >> x) & 1);
    }

    /// <summary>
    /// Returns whether or not this slot is currently in use/holding an item.
    /// <br/>Note, for performance purposes this doesn't check if the slot is unlocked and only checks if it's in use.
    /// </summary>
    /// <param name="x">zero based x position of the slot.</param>
    /// <param name="y">zero based y position of the slot.</param>
    /// <returns></returns>
    public unsafe bool IsSlotInUse(int x, int y) => IsSlotInUse(x, y, GetUsedIndecies());

    private unsafe bool IsSlotInUse(int x, int y, List<Vector2> usedSlots)
    {
        return usedSlots.Any(s => s.X == x && s.Y == y);
    }

    *//*public bool AddItem(InventoryItem itemToAdd)
    {
        var firstFreeSlot = Slots.FirstOrDefault(s => s.IsUnlocked() && !s.IsHoldingItem());
        if (firstFreeSlot == null)
            return false;


        return true;
    }*//*

    private unsafe List<Vector2> GetUsedIndecies()
    {
        List<Vector2> usedIndexes = new List<Vector2>();

        var addressToSlots = address + GetOffset(nameof(AddressToUsedSlots));
        var currentItem = PrimitiveUtils.GetValue<long>(addressToSlots);
        var nextInventory_Maybe = PrimitiveUtils.GetValue<long>(addressToSlots + 0x8);

        do
        {
            int x = PrimitiveUtils.GetValue<int>(currentItem + 40);
            int y = PrimitiveUtils.GetValue<int>(currentItem + 44);

            usedIndexes.Add(new Vector2(x, y));
            currentItem += 48;

        } while (currentItem < nextInventory_Maybe);

        return usedIndexes;
    }
}
*/