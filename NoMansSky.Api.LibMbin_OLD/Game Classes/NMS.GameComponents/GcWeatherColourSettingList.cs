using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherColourSettingList : NMSTemplate
{
	public VirtualList<GcPlanetWeatherColourData> Settings
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlanetWeatherColourData>(address + GetOffset()));
		set => TrySetValue<GcPlanetWeatherColourData>(value);
	}

	public GcWeatherColourSettingList(long address) : base(address)
	{

	}
}
