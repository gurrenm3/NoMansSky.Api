using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBasePlacementComponentData : NMSTemplate
{
	public VirtualList<GcBasePlacementRule> Rules
	{
		get => cache.GetOrAddValue(new VirtualList<GcBasePlacementRule>(address + GetOffset()));
		set => TrySetValue<GcBasePlacementRule>(value);
	}

	public GcBasePlacementComponentData(long address) : base(address)
	{

	}
}
