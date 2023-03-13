using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryContainer : NMSTemplate
{
	public VirtualList<GcInventoryElement> Slots
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryElement>(address + GetOffset()));
		set => TrySetValue<GcInventoryElement>(value);
	}

	public VirtualList<GcInventoryIndex> ValidSlotIndices
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryIndex>(address + GetOffset()));
		set => TrySetValue<GcInventoryIndex>(value);
	}

	public GcInventoryClass Class
	{
		get => GetValue<GcInventoryClass>();
		set => TrySetValue<GcInventoryClass>(value);
	}

	public GcInventoryStackSizeGroup StackSizeGroup
	{
		get => GetValue<GcInventoryStackSizeGroup>();
		set => TrySetValue<GcInventoryStackSizeGroup>(value);
	}

	public VirtualList<GcInventoryBaseStatEntry> BaseStatValues
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryBaseStatEntry>(address + GetOffset()));
		set => TrySetValue<GcInventoryBaseStatEntry>(value);
	}

	public VirtualList<GcInventorySpecialSlot> SpecialSlots
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventorySpecialSlot>(address + GetOffset()));
		set => TrySetValue<GcInventorySpecialSlot>(value);
	}

	public Int32 Width
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Height
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean IsCool
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x100 Name
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Int32 Version
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryContainer(long address) : base(address)
	{

	}
}
