using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSelectableObjectTable : NMSTemplate
{
	public VirtualList<GcSelectableObjectList> Lists
	{
		get => cache.GetOrAddValue(new VirtualList<GcSelectableObjectList>(address + GetOffset()));
		set => TrySetValue<GcSelectableObjectList>(value);
	}

	public GcSelectableObjectTable(long address) : base(address)
	{

	}
}
