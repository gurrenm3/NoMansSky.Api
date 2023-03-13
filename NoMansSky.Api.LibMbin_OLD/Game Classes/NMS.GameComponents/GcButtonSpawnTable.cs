using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcButtonSpawnTable : NMSTemplate
{
	public VirtualList<GcButtonSpawn> ButtonSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcButtonSpawn>(address + GetOffset()));
		set => TrySetValue<GcButtonSpawn>(value);
	}

	public GcButtonSpawnTable(long address) : base(address)
	{

	}
}
