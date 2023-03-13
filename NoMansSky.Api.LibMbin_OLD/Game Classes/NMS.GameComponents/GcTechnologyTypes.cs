using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTechnologyTypes : NMSTemplate
{
	public VirtualList<GcTechnology> Technology
	{
		get => cache.GetOrAddValue(new VirtualList<GcTechnology>(address + GetOffset()));
		set => TrySetValue<GcTechnology>(value);
	}

	public GcTechnologyTypes(long address) : base(address)
	{

	}
}
