using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkResourceFilterList : NMSTemplate
{
	public VirtualList<TkResourceFilterData> Filters
	{
		get => cache.GetOrAddValue(new VirtualList<TkResourceFilterData>(address + GetOffset()));
		set => TrySetValue<TkResourceFilterData>(value);
	}

	public TkResourceFilterList(long address) : base(address)
	{

	}
}
