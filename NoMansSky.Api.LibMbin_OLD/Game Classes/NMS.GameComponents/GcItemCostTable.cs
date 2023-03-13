using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcItemCostTable : NMSTemplate
{
	public VirtualList<GcItemCostData> Items
	{
		get => cache.GetOrAddValue(new VirtualList<GcItemCostData>(address + GetOffset()));
		set => TrySetValue<GcItemCostData>(value);
	}

	public GcItemCostTable(long address) : base(address)
	{

	}
}
