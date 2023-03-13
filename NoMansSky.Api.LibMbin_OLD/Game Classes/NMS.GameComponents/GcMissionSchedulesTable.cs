using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSchedulesTable : NMSTemplate
{
	public VirtualList<GcMissionSchedulingData> Schedules
	{
		get => cache.GetOrAddValue(new VirtualList<GcMissionSchedulingData>(address + GetOffset()));
		set => TrySetValue<GcMissionSchedulingData>(value);
	}

	public GcMissionSchedulesTable(long address) : base(address)
	{

	}
}
