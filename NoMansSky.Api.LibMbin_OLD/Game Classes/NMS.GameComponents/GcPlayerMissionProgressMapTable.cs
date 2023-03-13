using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerMissionProgressMapTable : NMSTemplate
{
	public VirtualList<GcPlayerMissionProgressMapEntry> MissionProgressTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerMissionProgressMapEntry>(address + GetOffset()));
		set => TrySetValue<GcPlayerMissionProgressMapEntry>(value);
	}

	public GcPlayerMissionProgressMapTable(long address) : base(address)
	{

	}
}
