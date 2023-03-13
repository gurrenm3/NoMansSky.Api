using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWaterGlobals : NMSTemplate
{
	public Boolean RenderReflections
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseNewWater
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WaveHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaveFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaveChoppiness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaveCutoff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Epsilon
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelPow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelBelowPow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelBelowMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelBelowAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour WaterHeavyAirColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcPlanetWaterData WaterDataDay
	{
		get => GetValue<GcPlanetWaterData>();
		set => TrySetValue<GcPlanetWaterData>(value);
	}

	public GcPlanetWaterColourData WaterColourNight
	{
		get => GetValue<GcPlanetWaterColourData>();
		set => TrySetValue<GcPlanetWaterColourData>(value);
	}

	public GcWaterGlobals(long address) : base(address)
	{

	}
}
