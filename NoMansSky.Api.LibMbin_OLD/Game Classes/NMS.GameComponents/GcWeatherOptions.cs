using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherOptions : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWeatherOptions.WeatherEnum Weather
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWeatherOptions.WeatherEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWeatherOptions.WeatherEnum>(value);
	}

	public GcWeatherOptions(long address) : base(address)
	{

	}
}
