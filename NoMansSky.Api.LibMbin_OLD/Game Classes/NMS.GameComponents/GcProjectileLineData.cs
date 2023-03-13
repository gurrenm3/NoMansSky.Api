using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProjectileLineData : NMSTemplate
{
	public Single BulletLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletGlowWidthTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletGlowWidthMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletGlowWidthMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType BulletGlowWidthCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single BulletScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletScalerMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletScalerMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletMinScaleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletMaxScaleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcProjectileLineData(long address) : base(address)
	{

	}
}
