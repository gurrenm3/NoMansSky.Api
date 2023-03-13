using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDebrisData : NMSTemplate
{
	public TkModelResource Filename
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Int32 Number
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnglularSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSeed OverrideSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcDebrisData(long address) : base(address)
	{

	}
}
