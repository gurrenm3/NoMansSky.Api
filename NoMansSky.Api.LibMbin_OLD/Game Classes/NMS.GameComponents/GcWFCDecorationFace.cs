using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCDecorationFace : NMSTemplate
{
	public NMSString0x80 RequiredFace
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCDecorationFace.CanWalkEnum CanWalk
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCDecorationFace.CanWalkEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCDecorationFace.CanWalkEnum>(value);
	}

	public GcWFCDecorationFace(long address) : base(address)
	{

	}
}
