using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryCostData : NMSTemplate
{
	public VirtualArray<GcInventoryCostDataEntry> InventoryCostData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInventoryCostDataEntry>(address + GetOffset(), 9));
		set => TrySetValue<GcInventoryCostDataEntry>(value);
	}

	public GcInventoryCostData(long address) : base(address)
	{

	}
}
