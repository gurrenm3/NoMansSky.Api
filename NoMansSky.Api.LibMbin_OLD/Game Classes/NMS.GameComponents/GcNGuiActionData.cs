using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiActionData : NMSTemplate
{
	public NMSString0x10 LayerID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Data
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.GameComponents.GcNGuiActionData.ActionEnum Action
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNGuiActionData.ActionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNGuiActionData.ActionEnum>(value);
	}

	public GcNGuiActionData(long address) : base(address)
	{

	}
}
