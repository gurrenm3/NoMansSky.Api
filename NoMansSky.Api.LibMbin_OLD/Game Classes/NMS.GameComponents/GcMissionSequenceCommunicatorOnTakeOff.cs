using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceCommunicatorOnTakeOff : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcPlayerCommunicatorMessage Comms
	{
		get => GetValue<GcPlayerCommunicatorMessage>();
		set => TrySetValue<GcPlayerCommunicatorMessage>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceCommunicatorOnTakeOff(long address) : base(address)
	{

	}
}
