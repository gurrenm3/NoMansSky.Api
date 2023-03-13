using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTechnologyTable : NMSTemplate
{
	public VirtualList<GcTechnology> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcTechnology>(address + GetOffset()));
		set => TrySetValue<GcTechnology>(value);
	}

	public GcTechnologyTable(long address) : base(address)
	{

	}
}
