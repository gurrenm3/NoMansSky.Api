using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherWeightings : NMSTemplate
{
	public VirtualArray<Single> WeatherWeightings
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 16));
		set => TrySetValue<Single>(value);
	}

	public GcWeatherWeightings(long address) : base(address)
	{

	}
}
