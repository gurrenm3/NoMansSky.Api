using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMaintenanceGroupsTable : NMSTemplate
{
	public VirtualArray<GcMaintenanceGroup> Groups
	{
		get => cache.GetOrAddValue(new VirtualArray<GcMaintenanceGroup>(address + GetOffset(), 7));
		set => TrySetValue<GcMaintenanceGroup>(value);
	}

	public GcMaintenanceGroupsTable(long address) : base(address)
	{

	}
}
