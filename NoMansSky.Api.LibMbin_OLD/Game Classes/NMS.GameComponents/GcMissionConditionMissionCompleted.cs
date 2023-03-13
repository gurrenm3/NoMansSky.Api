using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionMissionCompleted : NMSTemplate
{
	public NMSString0x10 MissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionMissionCompleted(long address) : base(address)
	{

	}
}
