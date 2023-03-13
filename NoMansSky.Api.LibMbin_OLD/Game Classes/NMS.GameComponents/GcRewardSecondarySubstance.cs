using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSecondarySubstance : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single AmountFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RewardAsBlobs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSecondarySubstance(long address) : base(address)
	{

	}
}
