using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEnvironmentProperties : NMSTemplate
{
	public Single FlightFogHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlightFogBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeavyAirHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeavyAirHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetObjectSwitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetLodSwitch0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetLodSwitch0Elevation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetLodSwitch1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetLodSwitch2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetLodSwitch3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidFadeHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidFadeHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> SkyHeight
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single SkyAtmosphereHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonBlendHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonBlendLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkyColourHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkyColourBlendLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkyPositionHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkyPositionBlendLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolarSystemLUTHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolarSystemLUTBlendLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereStartHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereEndHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StratosphereHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcEnvironmentProperties(long address) : base(address)
	{

	}
}
