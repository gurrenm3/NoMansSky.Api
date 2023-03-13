using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoModeAdjustData : NMSTemplate
{
	public Single AdjustMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AdjustMinCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single AdjustMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AdjustMaxRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AdjustMaxCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Boolean Inverted
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPhotoModeAdjustData(long address) : base(address)
	{

	}
}
