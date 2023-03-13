using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetWeatherColourData : NMSTemplate
{
	public Colour SkyColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SkyUpperColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SkySolarColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HorizonColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SunColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour FogColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HeightFogColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector3f SkyGradientSpeed
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Colour LightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CloudColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CloudColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcPlanetWeatherColourData(long address) : base(address)
	{

	}
}
