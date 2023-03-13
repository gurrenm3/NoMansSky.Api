using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHUDEffectRewardData : NMSTemplate
{
	public Int32 NumBoxes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single BoxAnimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoxRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoxAnimTimeBetweenBoxes
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType BoxAnimTimeCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Vector2f BoxSizeStart
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single BoxThicknessStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour BoxColourStart
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector2f BoxSizeEnd
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Colour BoxColourEnd
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single BoxThicknessEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcHUDEffectRewardData(long address) : base(address)
	{

	}
}
