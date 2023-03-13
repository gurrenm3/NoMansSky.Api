using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFogProperties : NMSTemplate
{
	public Single FogStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FogMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FogColourStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FogColourMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightFogStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightFogFadeOutStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightFogOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightFogMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FogHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcHeavyAirSetting HeavyAir
	{
		get => GetValue<GcHeavyAirSetting>();
		set => TrySetValue<GcHeavyAirSetting>(value);
	}

	public Single CloudRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FullscreenEffect
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DepthOfField
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DepthOfFieldDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DepthOfFieldFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean IsRaining
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single RainWetness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFogProperties(long address) : base(address)
	{

	}
}
