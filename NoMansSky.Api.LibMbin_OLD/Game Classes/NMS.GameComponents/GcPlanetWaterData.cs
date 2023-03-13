using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetWaterData : NMSTemplate
{
	public Int32 ColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single WaterStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterColourStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterMultiplyStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterMultiplyMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterRoughness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Wave1Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Wave1Height
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Wave1Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Wave2Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Wave2Height
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Wave2Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalMap1Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalMap1Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalMap2Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalMap2Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoamFadeHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Foam1Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Foam1Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Foam2Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Foam2Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlanetHeavyAirData HeavyAir
	{
		get => GetValue<GcPlanetHeavyAirData>();
		set => TrySetValue<GcPlanetHeavyAirData>(value);
	}

	public GcPlanetWaterData(long address) : base(address)
	{

	}
}
