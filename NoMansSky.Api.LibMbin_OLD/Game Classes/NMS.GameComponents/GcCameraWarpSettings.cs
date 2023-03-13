using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraWarpSettings : NMSTemplate
{
	public Single FocusPointDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZFrequency_1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZFrequency_2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZPhase_1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZPhase_2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZStartBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYFrequency_1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYFrequency_2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYPhase_1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYPhase_2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYStartBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetXFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetXPhase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetXRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType OffsetXCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single RollRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single YawnRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraWarpSettings(long address) : base(address)
	{

	}
}
