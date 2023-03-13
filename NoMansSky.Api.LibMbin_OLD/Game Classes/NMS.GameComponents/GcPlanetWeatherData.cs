using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetWeatherData : NMSTemplate
{
	public GcWeatherOptions WeatherType
	{
		get => GetValue<GcWeatherOptions>();
		set => TrySetValue<GcWeatherOptions>(value);
	}

	public GcPlanetHeavyAirData HeavyAir
	{
		get => GetValue<GcPlanetHeavyAirData>();
		set => TrySetValue<GcPlanetHeavyAirData>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlanetWeatherData.WeatherIntensityEnum WeatherIntensity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherData.WeatherIntensityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherData.WeatherIntensityEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlanetWeatherData.StormFrequencyEnum StormFrequency
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherData.StormFrequencyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherData.StormFrequencyEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlanetWeatherData.AtmosphereTypeEnum AtmosphereType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherData.AtmosphereTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetWeatherData.AtmosphereTypeEnum>(value);
	}

	public Int32 DayColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DuskColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcScreenFilters ScreenFilter
	{
		get => GetValue<GcScreenFilters>();
		set => TrySetValue<GcScreenFilters>(value);
	}

	public GcScreenFilters StormScreenFilter
	{
		get => GetValue<GcScreenFilters>();
		set => TrySetValue<GcScreenFilters>(value);
	}

	public GcRainbowType RainbowType
	{
		get => GetValue<GcRainbowType>();
		set => TrySetValue<GcRainbowType>(value);
	}

	public Int32 NightColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPlanetWeatherData(long address) : base(address)
	{

	}
}
