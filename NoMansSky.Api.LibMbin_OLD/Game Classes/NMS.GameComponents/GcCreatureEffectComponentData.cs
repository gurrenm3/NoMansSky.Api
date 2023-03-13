using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureEffectComponentData : NMSTemplate
{
	public VirtualList<GcCreatureEffectTrigger> AnimTriggers
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureEffectTrigger>(address + GetOffset()));
		set => TrySetValue<GcCreatureEffectTrigger>(value);
	}

	public GcCreatureEffectComponentData(long address) : base(address)
	{

	}
}
