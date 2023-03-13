using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInputBindings : NMSTemplate
{
	public VirtualList<GcInputBindingSet> InputBindingSets
	{
		get => cache.GetOrAddValue(new VirtualList<GcInputBindingSet>(address + GetOffset()));
		set => TrySetValue<GcInputBindingSet>(value);
	}

	public GcInputBindings(long address) : base(address)
	{

	}
}
