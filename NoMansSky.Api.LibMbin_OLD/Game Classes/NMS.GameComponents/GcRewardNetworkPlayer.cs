using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardNetworkPlayer : NMSTemplate
{
	public NMSString0x40 RewardWord
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcRewardNetworkPlayer(long address) : base(address)
	{

	}
}
