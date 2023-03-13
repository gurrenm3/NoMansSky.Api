using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiTextData : NMSTemplate
{
	public GcNGuiElementData ElementData
	{
		get => GetValue<GcNGuiElementData>();
		set => TrySetValue<GcNGuiElementData>(value);
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

	public NMSString0x200 Text
	{
		get => GetValue<NMSString0x200>();
		set => TrySetValue<NMSString0x200>(value);
	}

	public Boolean Special
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ForcedOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForcedAllowScroll
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcVROverride_Text> VROverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcVROverride_Text>(address + GetOffset()));
		set => TrySetValue<GcVROverride_Text>(value);
	}

	public VirtualList<GcAccessibleOverride_Text> AccessibleOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcAccessibleOverride_Text>(address + GetOffset()));
		set => TrySetValue<GcAccessibleOverride_Text>(value);
	}

	public GcNGuiTextData(long address) : base(address)
	{

	}
}
