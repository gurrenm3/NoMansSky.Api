using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerMissionUpgradeMapTable : NMSTemplate
{
	public VirtualList<GcPlayerMissionUpgradeMapEntry> MissionProgressTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerMissionUpgradeMapEntry>(address + GetOffset()));
		set => TrySetValue<GcPlayerMissionUpgradeMapEntry>(value);
	}

	public GcPlayerMissionUpgradeMapTable(long address) : base(address)
	{

	}
}
