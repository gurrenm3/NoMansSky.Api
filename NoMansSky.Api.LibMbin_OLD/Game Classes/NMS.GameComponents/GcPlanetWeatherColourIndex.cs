using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetWeatherColourIndex : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlanetWeatherColourIndex.WeatherColourSetEnum WeatherColourSet
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherColourIndex.WeatherColourSetEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherColourIndex.WeatherColourSetEnum>(value);
	}

	public Int32 Index
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPlanetWeatherColourIndex(long address) : base(address)
	{

	}
}
