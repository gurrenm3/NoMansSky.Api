using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiLayerData : NMSTemplate
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

	public VirtualList<NMSTemplate> Children
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public NMSString0x80 DataFilename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.GameComponents.GcNGuiLayerData.AltModeEnum AltMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNGuiLayerData.AltModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNGuiLayerData.AltModeEnum>(value);
	}

	public GcNGuiLayerData(long address) : base(address)
	{

	}
}
