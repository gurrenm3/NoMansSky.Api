using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceSkyProperties : NMSTemplate
{
	public GcPlanetWeatherColourIndex ColourIndex
	{
		get => GetValue<GcPlanetWeatherColourIndex>();
		set => TrySetValue<GcPlanetWeatherColourIndex>(value);
	}

	public Colour PlanetSkyColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PlanetHorizonColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single SunStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarVisibility
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CenterPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonFadeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetFogStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceFogStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceFogColourStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceFogColour2Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceFogMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceFogPlanetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaSparseness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaWispyness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaWispyness1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaBrightness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaSeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaTendrilStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaFogAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaCloudStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaCloudStrength1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaNoiseFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudNoiseFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaTurbulenceStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaFBMStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaFBMStrength1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaDistortionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSpaceSkyProperties(long address) : base(address)
	{

	}
}
