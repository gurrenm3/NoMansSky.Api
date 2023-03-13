using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardMissionMessageToMatchingSeeds : NMSTemplate
{
	public NMSString0x10 MessageID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean BroadcastInMultiplayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardMissionMessageToMatchingSeeds(long address) : base(address)
	{

	}
}
