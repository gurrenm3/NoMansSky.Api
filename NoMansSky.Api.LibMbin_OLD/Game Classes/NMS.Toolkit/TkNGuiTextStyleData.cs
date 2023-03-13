using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiTextStyleData : NMSTemplate
{
	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single FontHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FontSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean IsIndented
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasDropShadow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour ShadowColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single DropShadowAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DropShadowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HasOutline
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single OutlineSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour OutlineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Boolean IsParagraph
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowScroll
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceUpperCase
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoAdjustHeight
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BlockAudio
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 FontIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkNGuiAlignment Align
	{
		get => GetValue<TkNGuiAlignment>();
		set => TrySetValue<TkNGuiAlignment>(value);
	}

	public TkNGuiTextStyleData(long address) : base(address)
	{

	}
}
