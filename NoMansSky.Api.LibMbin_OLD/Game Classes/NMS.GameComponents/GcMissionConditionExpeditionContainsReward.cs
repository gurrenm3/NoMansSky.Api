using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionExpeditionContainsReward : NMSTemplate
{
	public NMSString0x10 RewardID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionExpeditionContainsReward(long address) : base(address)
	{

	}
}
