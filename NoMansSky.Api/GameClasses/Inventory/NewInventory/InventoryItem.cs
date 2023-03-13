/*using NoMansSky.Api.LibMbin;
using System;
using System.Reflection;

namespace NoMansSky.Api.GameClasses.Inventory.NewInventory;

public class InventoryItem : NMSTemplate
{
    public GcInventoryType Type
    {
        get => GetValue<GcInventoryType>();
        set => TrySetValue<GcInventoryType>(value);
    }

    public NMSString0x10 Id
    {
        get => GetValue<NMSString0x10>();
        set => TrySetValue<NMSString0x10>(value);
    }

    public Int32 Amount
    {
        get => GetValue<Int32>();
        set => TrySetValue<Int32>(value);
    }

    public Int32 MaxAmount
    {
        get => GetValue<Int32>();
        set => TrySetValue<Int32>(value);
    }

    public Single DamageFactor
    {
        get => GetValue<Single>();
        set => TrySetValue<Single>(value);
    }

    public Boolean FullyInstalled
    {
        get => GetValue<Boolean>();
        set => TrySetValue<Boolean>(value);
    }

    internal GcInventoryIndex Index
    {
        get => GetValue<GcInventoryIndex>();
        set => TrySetValue<GcInventoryIndex>(value);
    }

    public InventoryItem(long address) : base(address)
    {
        
    }

    public InventoryItem(GcInventoryElement element) : this(element.address)
    {

    }
}
*/