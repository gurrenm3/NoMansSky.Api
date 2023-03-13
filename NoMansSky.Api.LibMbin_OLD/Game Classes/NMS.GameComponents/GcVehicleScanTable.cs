using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleScanTable : NMSTemplate
{
	public VirtualList<GcVehicleScanTableEntry> VehicleScanTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcVehicleScanTableEntry>(address + GetOffset()));
		set => TrySetValue<GcVehicleScanTableEntry>(value);
	}

	public GcVehicleScanTable(long address) : base(address)
	{

	}
}
