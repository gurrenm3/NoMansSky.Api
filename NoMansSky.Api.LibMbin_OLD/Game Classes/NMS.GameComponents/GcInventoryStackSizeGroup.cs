using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryStackSizeGroup : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum InventoryStackSizeGroup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum>(value);
	}

	public GcInventoryStackSizeGroup(long address) : base(address)
	{

	}
}
