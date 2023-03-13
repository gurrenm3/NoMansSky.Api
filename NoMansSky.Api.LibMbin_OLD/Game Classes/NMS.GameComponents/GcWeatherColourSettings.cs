using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherColourSettings : NMSTemplate
{
	public GcWeatherColourSettingList GenericSettings
	{
		get => GetValue<GcWeatherColourSettingList>();
		set => TrySetValue<GcWeatherColourSettingList>(value);
	}

	public VirtualArray<GcWeatherColourSettingList> PerBiomeSettings
	{
		get => cache.GetOrAddValue(new VirtualArray<GcWeatherColourSettingList>(address + GetOffset(), 16));
		set => TrySetValue<GcWeatherColourSettingList>(value);
	}

	public GcWeatherColourSettings(long address) : base(address)
	{

	}
}
