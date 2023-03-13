using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardRepairWholeInventory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardRepairWholeInventory.InventoryToRepairEnum InventoryToRepair
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardRepairWholeInventory.InventoryToRepairEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardRepairWholeInventory.InventoryToRepairEnum>(value);
	}

	public GcRewardRepairWholeInventory(long address) : base(address)
	{

	}
}
