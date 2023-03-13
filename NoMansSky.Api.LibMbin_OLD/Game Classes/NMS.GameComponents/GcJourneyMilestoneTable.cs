using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcJourneyMilestoneTable : NMSTemplate
{
	public VirtualList<GcJourneyMilestoneData> JourneyMilestoneTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcJourneyMilestoneData>(address + GetOffset()));
		set => TrySetValue<GcJourneyMilestoneData>(value);
	}

	public GcJourneyMilestoneTable(long address) : base(address)
	{

	}
}
