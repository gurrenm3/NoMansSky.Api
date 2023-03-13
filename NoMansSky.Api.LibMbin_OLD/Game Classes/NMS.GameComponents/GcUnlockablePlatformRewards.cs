using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockablePlatformRewards : NMSTemplate
{
	public VirtualList<GcUnlockablePlatformReward> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcUnlockablePlatformReward>(address + GetOffset()));
		set => TrySetValue<GcUnlockablePlatformReward>(value);
	}

	public GcUnlockablePlatformRewards(long address) : base(address)
	{

	}
}
