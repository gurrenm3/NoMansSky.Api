using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceSummonNexus : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceSummonNexus(long address) : base(address)
	{

	}
}
