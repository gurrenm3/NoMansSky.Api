using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherEffectTable : NMSTemplate
{
	public VirtualList<GcWeatherEffect> Effects
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeatherEffect>(address + GetOffset()));
		set => TrySetValue<GcWeatherEffect>(value);
	}

	public GcWeatherEffectTable(long address) : base(address)
	{

	}
}
