using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSkyProperties : NMSTemplate
{
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

	public Single DuskHorizonMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightHorizonMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonFadeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DayHorizonTightness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunSurroundSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunSurroundStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpperSkyFadeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpperSkyFadeOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSkyProperties(long address) : base(address)
	{

	}
}
