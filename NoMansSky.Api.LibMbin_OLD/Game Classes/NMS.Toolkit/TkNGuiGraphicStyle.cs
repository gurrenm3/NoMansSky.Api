using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiGraphicStyle : NMSTemplate
{
	public TkNGuiGraphicStyleData Default
	{
		get => GetValue<TkNGuiGraphicStyleData>();
		set => TrySetValue<TkNGuiGraphicStyleData>(value);
	}

	public TkNGuiGraphicStyleData Highlight
	{
		get => GetValue<TkNGuiGraphicStyleData>();
		set => TrySetValue<TkNGuiGraphicStyleData>(value);
	}

	public TkNGuiGraphicStyleData Active
	{
		get => GetValue<TkNGuiGraphicStyleData>();
		set => TrySetValue<TkNGuiGraphicStyleData>(value);
	}

	public Boolean InheritStyleFromParentLayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HighlightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HighlightScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GlobalFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkNGuiGraphicStyle.AnimateEnum Animate
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiGraphicStyle.AnimateEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiGraphicStyle.AnimateEnum>(value);
	}

	public Single AnimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimSplit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AnimCurve1
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType AnimCurve2
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Vector2f CustomMinStart
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f CustomMaxStart
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public TkNGuiGraphicStyle(long address) : base(address)
	{

	}
}
