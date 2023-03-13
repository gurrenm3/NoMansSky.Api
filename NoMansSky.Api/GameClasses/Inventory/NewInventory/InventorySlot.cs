/*using System;
using System.Collections;

namespace NoMansSky.Api.GameClasses.Inventory.NewInventory;

public class InventorySlot
{
    public InventoryItem HeldItem { get; private set; }
    public int X { get; set; }
    public int Y { get; set; }

    private readonly Inventory _owner;

    public InventorySlot(Inventory owner)
    {
        _owner = owner;
    }

    public bool SetItem(InventoryItem item)
    {
        HeldItem = item;
        item.Index.X = X;
        item.Index.Y = Y;

        *//*if (!IsUnlocked())
            return false;

        if (IsHoldingItem())
        {
            // might need to swap items?
        }
        else
        {

        }*//*

        return true;
    }

    public bool IsHoldingItem()
    {
        return false;
    }

    public unsafe bool IsUnlocked()
    {
        return _owner.IsSlotUnlocked(X, Y);
    }

    public bool IsInUse()
    {
        return _owner.IsSlotInUse(X, Y);
    }
}
*/