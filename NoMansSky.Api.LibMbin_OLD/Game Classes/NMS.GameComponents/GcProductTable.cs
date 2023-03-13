using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProductTable : NMSTemplate
{
	public VirtualList<GcProductData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcProductData>(address + GetOffset()));
		set => TrySetValue<GcProductData>(value);
	}

	public GcProductTable(long address) : base(address)
	{

	}
}
