using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiEditorStyleData : NMSTemplate
{
	public VirtualArray<Single> Sizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 48));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<TkNGuiEditorStyleColour> SkinColours
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNGuiEditorStyleColour>(address + GetOffset(), 8));
		set => TrySetValue<TkNGuiEditorStyleColour>(value);
	}

	public Single SkinFontHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 Font
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<TkNGuiGraphicStyle> GraphicStyles
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNGuiGraphicStyle>(address + GetOffset(), 72));
		set => TrySetValue<TkNGuiGraphicStyle>(value);
	}

	public VirtualArray<TkNGuiTextStyle> TextStyles
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNGuiTextStyle>(address + GetOffset(), 14));
		set => TrySetValue<TkNGuiTextStyle>(value);
	}

	public VirtualList<Single> SnapSettings
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public TkNGuiEditorStyleData(long address) : base(address)
	{

	}
}
