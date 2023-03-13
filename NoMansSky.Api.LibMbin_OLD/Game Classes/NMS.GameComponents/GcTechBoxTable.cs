using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTechBoxTable : NMSTemplate
{
	public VirtualList<GcTechBoxData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcTechBoxData>(address + GetOffset()));
		set => TrySetValue<GcTechBoxData>(value);
	}

	public GcTechBoxTable(long address) : base(address)
	{

	}
}
