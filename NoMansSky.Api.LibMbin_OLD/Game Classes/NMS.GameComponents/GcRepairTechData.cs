using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRepairTechData : NMSTemplate
{
	public GcMaintenanceContainer MaintenanceContainer
	{
		get => GetValue<GcMaintenanceContainer>();
		set => TrySetValue<GcMaintenanceContainer>(value);
	}

	public Int32 InventoryType
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 InventorySubIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryIndex InventoryIndex
	{
		get => GetValue<GcInventoryIndex>();
		set => TrySetValue<GcInventoryIndex>(value);
	}

	public GcRepairTechData(long address) : base(address)
	{

	}
}
