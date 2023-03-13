using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateTraitTable : NMSTemplate
{
	public VirtualList<GcFrigateTraitData> Traits
	{
		get => cache.GetOrAddValue(new VirtualList<GcFrigateTraitData>(address + GetOffset()));
		set => TrySetValue<GcFrigateTraitData>(value);
	}

	public GcFrigateTraitTable(long address) : base(address)
	{

	}
}
