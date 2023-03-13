using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterNPCSpawnPriority : NMSTemplate
{
	public VirtualList<Single> PriorityScale
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public GcFreighterNPCSpawnPriority(long address) : base(address)
	{

	}
}
