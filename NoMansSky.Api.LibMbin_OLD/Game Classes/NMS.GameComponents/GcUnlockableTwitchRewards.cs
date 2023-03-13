using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableTwitchRewards : NMSTemplate
{
	public VirtualList<GcUnlockableTwitchReward> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcUnlockableTwitchReward>(address + GetOffset()));
		set => TrySetValue<GcUnlockableTwitchReward>(value);
	}

	public GcUnlockableTwitchRewards(long address) : base(address)
	{

	}
}
