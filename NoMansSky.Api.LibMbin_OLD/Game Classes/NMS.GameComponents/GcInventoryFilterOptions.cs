using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryFilterOptions : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInventoryFilterOptions.InventoryFilterEnum InventoryFilter
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventoryFilterOptions.InventoryFilterEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventoryFilterOptions.InventoryFilterEnum>(value);
	}

	public GcInventoryFilterOptions(long address) : base(address)
	{

	}
}
