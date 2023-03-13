using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherProperties : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean UseWeatherFog
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcFogProperties Fog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcFogProperties FlightFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcFogProperties StormFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcFogProperties ExtremeFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcWeatherColourModifiers ExtremeColourModifiers
	{
		get => GetValue<GcWeatherColourModifiers>();
		set => TrySetValue<GcWeatherColourModifiers>(value);
	}

	public VirtualArray<Single> RainbowChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcStormProperties> Storms
	{
		get => cache.GetOrAddValue(new VirtualList<GcStormProperties>(address + GetOffset()));
		set => TrySetValue<GcStormProperties>(value);
	}

	public VirtualList<NMSString0x80> HeavyAir
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single LowStormsChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HighStormsChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExtremeWeatherChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean OverrideTemperature
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcHazardValues> Temperature
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHazardValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHazardValues>(value);
	}

	public Boolean OverrideToxicity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcHazardValues> Toxicity
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHazardValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHazardValues>(value);
	}

	public Boolean OverrideRadiation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcHazardValues> Radiation
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHazardValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHazardValues>(value);
	}

	public VirtualArray<GcHazardValues> LifeSupportDrain
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHazardValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHazardValues>(value);
	}

	public VirtualList<GcScreenFilters> StormFilterOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcScreenFilters>(address + GetOffset()));
		set => TrySetValue<GcScreenFilters>(value);
	}

	public Boolean UseWeatherSky
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSkyProperties Sky
	{
		get => GetValue<GcSkyProperties>();
		set => TrySetValue<GcSkyProperties>(value);
	}

	public Boolean UseLightShaftProperties
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcLightShaftProperties LightShaftProperties
	{
		get => GetValue<GcLightShaftProperties>();
		set => TrySetValue<GcLightShaftProperties>(value);
	}

	public Boolean UseStormLightShaftProperties
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcLightShaftProperties StormLightShaftProperties
	{
		get => GetValue<GcLightShaftProperties>();
		set => TrySetValue<GcLightShaftProperties>(value);
	}

	public VirtualList<NMSString0x10> WeatherEffectsIds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> WeatherHazardsIds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcWeatherProperties(long address) : base(address)
	{

	}
}
