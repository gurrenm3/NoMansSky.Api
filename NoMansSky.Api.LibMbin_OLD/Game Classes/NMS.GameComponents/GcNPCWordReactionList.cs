using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCWordReactionList : NMSTemplate
{
	public VirtualList<GcNPCProbabilityWordReactionData> Reactions
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityWordReactionData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityWordReactionData>(value);
	}

	public GcNPCWordReactionList(long address) : base(address)
	{

	}
}
