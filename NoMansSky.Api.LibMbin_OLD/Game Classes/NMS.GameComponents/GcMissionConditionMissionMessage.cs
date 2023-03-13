using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionMissionMessage : NMSTemplate
{
	public NMSString0x10 Message
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionMissionMessage(long address) : base(address)
	{

	}
}
