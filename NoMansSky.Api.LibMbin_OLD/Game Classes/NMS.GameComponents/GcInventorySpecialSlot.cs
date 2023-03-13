using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventorySpecialSlot : NMSTemplate
{
	public GcInventorySpecialSlotType Type
	{
		get => GetValue<GcInventorySpecialSlotType>();
		set => TrySetValue<GcInventorySpecialSlotType>(value);
	}

	public GcInventoryIndex Index
	{
		get => GetValue<GcInventoryIndex>();
		set => TrySetValue<GcInventoryIndex>(value);
	}

	public GcInventorySpecialSlot(long address) : base(address)
	{

	}
}
