using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHUDManagerData : NMSTemplate
{
	public GcTextPreset TitleFont
	{
		get => GetValue<GcTextPreset>();
		set => TrySetValue<GcTextPreset>(value);
	}

	public GcTextPreset SubtitleFont
	{
		get => GetValue<GcTextPreset>();
		set => TrySetValue<GcTextPreset>(value);
	}

	public GcTextPreset SubtitleFontSmall
	{
		get => GetValue<GcTextPreset>();
		set => TrySetValue<GcTextPreset>(value);
	}

	public Single OSDCoreSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDFullSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDCoreAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDBaseTextY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDBaseBandY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDBorderY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDUnderlineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpCoreSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpFullSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpCoreAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpYMidLock
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDFadeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDEdgeMergeAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDTextAppearRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDTextFadeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDTextWaitOnAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpFadeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpBGFadeInRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpBGFadeOutRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopUpBGTriggerFG
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PromptLine1Y
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PromptLine2Y
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ModelRenderTextureSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ModelRenderDisplaySize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ModelRenderDisplayBorder
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ModelRenderDisplayOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelRenderDisplayMove
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType ModelRenderDisplayAlphaCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType ModelRenderDisplayMoveCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public GcHUDManagerData(long address) : base(address)
	{

	}
}
