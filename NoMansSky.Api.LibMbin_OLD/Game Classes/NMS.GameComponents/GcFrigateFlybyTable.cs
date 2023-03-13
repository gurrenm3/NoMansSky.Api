using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateFlybyTable : NMSTemplate
{
	public VirtualList<GcFrigateFlybyLayout> Entries
	{
		get => cache.GetOrAddValue(new VirtualList<GcFrigateFlybyLayout>(address + GetOffset()));
		set => TrySetValue<GcFrigateFlybyLayout>(value);
	}

	public GcFrigateFlybyTable(long address) : base(address)
	{

	}
}
