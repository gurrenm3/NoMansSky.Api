using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureDataTable : NMSTemplate
{
	public VirtualList<GcCreatureData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureData>(address + GetOffset()));
		set => TrySetValue<GcCreatureData>(value);
	}

	public GcCreatureDataTable(long address) : base(address)
	{

	}
}
