using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionGlobalMission : NMSTemplate
{
	public GcRewardChangeGlobalMission Type
	{
		get => GetValue<GcRewardChangeGlobalMission>();
		set => TrySetValue<GcRewardChangeGlobalMission>(value);
	}

	public GcMissionConditionGlobalMission(long address) : base(address)
	{

	}
}
