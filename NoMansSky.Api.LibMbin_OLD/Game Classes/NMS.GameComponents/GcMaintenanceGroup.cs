using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMaintenanceGroup : NMSTemplate
{
	public VirtualList<GcMaintenanceGroupEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcMaintenanceGroupEntry>(address + GetOffset()));
		set => TrySetValue<GcMaintenanceGroupEntry>(value);
	}

	public GcMaintenanceGroup(long address) : base(address)
	{

	}
}
