using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceSkyColours : NMSTemplate
{
	public Colour CloudColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourTop
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourMid
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourBottom
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourTopPlanet
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourMidPlanet
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourBottomPlanet
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SunColour
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

	public Colour NebulaShadowColour
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

	public GcSpaceSkyColours(long address) : base(address)
	{

	}
}
