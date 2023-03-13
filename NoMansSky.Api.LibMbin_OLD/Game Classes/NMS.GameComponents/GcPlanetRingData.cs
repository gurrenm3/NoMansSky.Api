using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetRingData : NMSTemplate
{
	public Boolean HasRings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f Up
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Colour Colour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour Colour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single LargeScale1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeScale2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Depth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlphaMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlanetRingData(long address) : base(address)
	{

	}
}
