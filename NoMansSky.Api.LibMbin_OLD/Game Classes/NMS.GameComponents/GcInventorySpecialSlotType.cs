using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventorySpecialSlotType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInventorySpecialSlotType.InventorySpecialSlotTypeEnum InventorySpecialSlotType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventorySpecialSlotType.InventorySpecialSlotTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventorySpecialSlotType.InventorySpecialSlotTypeEnum>(value);
	}

	public GcInventorySpecialSlotType(long address) : base(address)
	{

	}
}
