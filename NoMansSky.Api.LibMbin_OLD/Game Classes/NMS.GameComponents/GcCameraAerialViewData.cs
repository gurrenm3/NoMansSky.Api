using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraAerialViewData : NMSTemplate
{
	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcCameraAerialViewData.AerialViewModeEnum AerialViewMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCameraAerialViewData.AerialViewModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCameraAerialViewData.AerialViewModeEnum>(value);
	}

	public Single TimeBack
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetOffsetAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Stages
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SpeedLineDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType Curve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType CurveDown
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType SlerpCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public GcCameraAerialViewData(long address) : base(address)
	{

	}
}
