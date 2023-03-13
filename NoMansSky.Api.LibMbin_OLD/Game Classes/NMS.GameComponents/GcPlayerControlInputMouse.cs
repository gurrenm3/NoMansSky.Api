using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerControlInputMouse : NMSTemplate
{
	public GcCharacterControlInputValidity Validity
	{
		get => GetValue<GcCharacterControlInputValidity>();
		set => TrySetValue<GcCharacterControlInputValidity>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerControlInputMouse.InputMouseModeEnum InputMouseMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerControlInputMouse.InputMouseModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerControlInputMouse.InputMouseModeEnum>(value);
	}

	public GcCharacterControlOutputSpace OutputSpace
	{
		get => GetValue<GcCharacterControlOutputSpace>();
		set => TrySetValue<GcCharacterControlOutputSpace>(value);
	}

	public NMSString0x10 Output
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 OutputLength
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlayerControlInputMouse(long address) : base(address)
	{

	}
}
