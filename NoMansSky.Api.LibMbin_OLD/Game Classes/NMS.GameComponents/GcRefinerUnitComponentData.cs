using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRefinerUnitComponentData : NMSTemplate
{
	public GcMaintenanceComponentData MaintenanceData
	{
		get => GetValue<GcMaintenanceComponentData>();
		set => TrySetValue<GcMaintenanceComponentData>(value);
	}

	public Int32 NumInputs
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean IsCooker
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRefinerUnitComponentData(long address) : base(address)
	{

	}
}
