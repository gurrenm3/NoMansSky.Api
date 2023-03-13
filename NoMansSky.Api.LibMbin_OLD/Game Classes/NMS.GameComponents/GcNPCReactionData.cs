using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCReactionData : NMSTemplate
{
	public VirtualList<GcNPCReactionEntry> Reactions
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCReactionEntry>(address + GetOffset()));
		set => TrySetValue<GcNPCReactionEntry>(value);
	}

	public GcNPCReactionData(long address) : base(address)
	{

	}
}
