using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionCanReceiveReward : NMSTemplate
{
	public NMSString0x10 Reward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionCanReceiveReward(long address) : base(address)
	{

	}
}
