using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEggMachineComponentData : NMSTemplate
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

	public GcEggMachineComponentData(long address) : base(address)
	{

	}
}
