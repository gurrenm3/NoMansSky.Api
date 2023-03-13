using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardChangeGlobalMission : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardChangeGlobalMission.GlobalMissionEnum GlobalMission
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardChangeGlobalMission.GlobalMissionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardChangeGlobalMission.GlobalMissionEnum>(value);
	}

	public GcRewardChangeGlobalMission(long address) : base(address)
	{

	}
}
