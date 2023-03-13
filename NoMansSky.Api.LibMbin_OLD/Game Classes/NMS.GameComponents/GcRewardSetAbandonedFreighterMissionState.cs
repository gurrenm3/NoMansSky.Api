using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSetAbandonedFreighterMissionState : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardSetAbandonedFreighterMissionState.AbandonedFreighterMissionStateEnum AbandonedFreighterMissionState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardSetAbandonedFreighterMissionState.AbandonedFreighterMissionStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardSetAbandonedFreighterMissionState.AbandonedFreighterMissionStateEnum>(value);
	}

	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSetAbandonedFreighterMissionState(long address) : base(address)
	{

	}
}
