using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLeveledStatTable : NMSTemplate
{
	public VirtualList<GcLeveledStatData> LeveledStatTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcLeveledStatData>(address + GetOffset()));
		set => TrySetValue<GcLeveledStatData>(value);
	}

	public GcLeveledStatTable(long address) : base(address)
	{

	}
}
