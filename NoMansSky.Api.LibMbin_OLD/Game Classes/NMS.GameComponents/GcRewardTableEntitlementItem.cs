using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTableEntitlementItem : NMSTemplate
{
	public NMSString0x10 RewardId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 EntitlementId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSTemplate Reward
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcRewardTableEntitlementItem(long address) : base(address)
	{

	}
}
