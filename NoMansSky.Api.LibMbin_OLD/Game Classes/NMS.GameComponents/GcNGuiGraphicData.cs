using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiGraphicData : NMSTemplate
{
	public GcNGuiElementData ElementData
	{
		get => GetValue<GcNGuiElementData>();
		set => TrySetValue<GcNGuiElementData>(value);
	}

	public TkNGuiGraphicStyle Style
	{
		get => GetValue<TkNGuiGraphicStyle>();
		set => TrySetValue<TkNGuiGraphicStyle>(value);
	}

	public NMSString0x80 Image
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcNGuiGraphicData(long address) : base(address)
	{

	}
}
