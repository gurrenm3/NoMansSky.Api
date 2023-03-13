using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureHarvesterComponentData : NMSTemplate
{
	public GcMaintenanceComponentData MaintenanceData
	{
		get => GetValue<GcMaintenanceComponentData>();
		set => TrySetValue<GcMaintenanceComponentData>(value);
	}

	public Int32 NumSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCreatureHarvesterComponentData(long address) : base(address)
	{

	}
}
