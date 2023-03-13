using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiElementData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 PresetID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean IsHidden
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkNGuiForcedStyle ForcedStyle
	{
		get => GetValue<TkNGuiForcedStyle>();
		set => TrySetValue<TkNGuiForcedStyle>(value);
	}

	public GcNGuiLayoutData Layout
	{
		get => GetValue<GcNGuiLayoutData>();
		set => TrySetValue<GcNGuiLayoutData>(value);
	}

	public GcNGuiElementData(long address) : base(address)
	{

	}
}
