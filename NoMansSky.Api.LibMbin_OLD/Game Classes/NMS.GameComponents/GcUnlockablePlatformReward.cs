using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockablePlatformReward : NMSTemplate
{
	public NMSString0x10 RewardId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ProductId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcUnlockablePlatformReward(long address) : base(address)
	{

	}
}
