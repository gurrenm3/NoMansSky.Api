using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCInteractionsDataTable : NMSTemplate
{
	public VirtualList<GcNPCInteractionData> NPCInteractions
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCInteractionData>(address + GetOffset()));
		set => TrySetValue<GcNPCInteractionData>(value);
	}

	public GcNPCInteractionsDataTable(long address) : base(address)
	{

	}
}
