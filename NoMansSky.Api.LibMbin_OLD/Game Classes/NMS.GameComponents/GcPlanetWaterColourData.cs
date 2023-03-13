using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetWaterColourData : NMSTemplate
{
	public Colour WaterFogColourNear
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour WaterFogColourFar
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour WaterColourBase
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour WaterColourAdd
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour FoamColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcPlanetWaterColourData(long address) : base(address)
	{

	}
}
