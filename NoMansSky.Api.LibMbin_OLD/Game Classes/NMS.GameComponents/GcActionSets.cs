using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActionSets : NMSTemplate
{
	public VirtualList<GcActionSet> ActionSets
	{
		get => cache.GetOrAddValue(new VirtualList<GcActionSet>(address + GetOffset()));
		set => TrySetValue<GcActionSet>(value);
	}

	public GcActionSets(long address) : base(address)
	{

	}
}
