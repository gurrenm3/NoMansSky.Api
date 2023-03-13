using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiPresetText : NMSTemplate
{
	public NMSString0x10 PresetID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcNGuiLayoutData Layout
	{
		get => GetValue<GcNGuiLayoutData>();
		set => TrySetValue<GcNGuiLayoutData>(value);
	}

	public TkNGuiTextStyle Style
	{
		get => GetValue<TkNGuiTextStyle>();
		set => TrySetValue<TkNGuiTextStyle>(value);
	}

	public TkNGuiGraphicStyle GraphicStyle
	{
		get => GetValue<TkNGuiGraphicStyle>();
		set => TrySetValue<TkNGuiGraphicStyle>(value);
	}

	public NMSString0x80 Image
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcNGuiPresetText(long address) : base(address)
	{

	}
}
