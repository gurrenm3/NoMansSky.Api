using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceSetGlobalMission : NMSTemplate
{
	public GcRewardChangeGlobalMission Type
	{
		get => GetValue<GcRewardChangeGlobalMission>();
		set => TrySetValue<GcRewardChangeGlobalMission>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceSetGlobalMission(long address) : base(address)
	{

	}
}
