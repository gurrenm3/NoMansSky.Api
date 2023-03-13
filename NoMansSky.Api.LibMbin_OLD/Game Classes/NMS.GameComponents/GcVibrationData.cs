using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVibrationData : NMSTemplate
{
	public Single OutputStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType OutputStrengthCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single DecayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Variance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VarianceContrast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcVibrationData(long address) : base(address)
	{

	}
}
