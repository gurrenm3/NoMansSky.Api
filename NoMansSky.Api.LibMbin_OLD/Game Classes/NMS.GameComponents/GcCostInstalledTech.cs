using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostInstalledTech : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcCostInstalledTech.InventoryToCheckEnum InventoryToCheck
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCostInstalledTech.InventoryToCheckEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCostInstalledTech.InventoryToCheckEnum>(value);
	}

	public GcCostInstalledTech(long address) : base(address)
	{

	}
}
