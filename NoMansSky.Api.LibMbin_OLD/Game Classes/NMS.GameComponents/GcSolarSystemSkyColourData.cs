using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemSkyColourData : NMSTemplate
{
	public Colour TopColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour MidColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BottomColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TopColourPlanet
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour MidColourPlanet
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BottomColourPlanet
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CloudColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour LightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NebulaColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NebulaColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NebulaColour3
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour FogColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour FogColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcSolarSystemSkyColourData(long address) : base(address)
	{

	}
}
