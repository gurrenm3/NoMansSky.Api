using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkHeavyAirCollection : NMSTemplate
{
	public VirtualList<TkHeavyAirData> HeavyAirSystems
	{
		get => cache.GetOrAddValue(new VirtualList<TkHeavyAirData>(address + GetOffset()));
		set => TrySetValue<TkHeavyAirData>(value);
	}

	public TkHeavyAirCollection(long address) : base(address)
	{

	}
}
