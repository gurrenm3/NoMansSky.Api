using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseFlattenPoint : NMSTemplate
{
	public Single Density
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlattenRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurbulenceFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurbulenceAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TurbulenceOctaves
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkNoiseFlattenOptions FlattenType
	{
		get => GetValue<TkNoiseFlattenOptions>();
		set => TrySetValue<TkNoiseFlattenOptions>(value);
	}

	public Int32 Classification
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Placement
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean AddWaypoint
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AddShelter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AddLandingPad
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkNoiseFlattenPoint(long address) : base(address)
	{

	}
}
