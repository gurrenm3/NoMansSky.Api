using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterMove : NMSTemplate
{
	public NMSString0x10 Input
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcCharacterMove.ModeEnum Mode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCharacterMove.ModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCharacterMove.ModeEnum>(value);
	}

	public GcCharacterMove(long address) : base(address)
	{

	}
}
