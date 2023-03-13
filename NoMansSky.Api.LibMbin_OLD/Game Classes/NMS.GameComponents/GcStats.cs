using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStats : NMSTemplate
{
	public VirtualList<GcStatsGroup> Stats
	{
		get => cache.GetOrAddValue(new VirtualList<GcStatsGroup>(address + GetOffset()));
		set => TrySetValue<GcStatsGroup>(value);
	}

	public GcStats(long address) : base(address)
	{

	}
}
