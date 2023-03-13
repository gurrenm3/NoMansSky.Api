using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureFeederComponentData : NMSTemplate
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

	public Int32 NumMealsPerBait
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x100> DispenseNodes
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x100>(address + GetOffset()));
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single DispenseVelocity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DispensePeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureFeederComponentData(long address) : base(address)
	{

	}
}
