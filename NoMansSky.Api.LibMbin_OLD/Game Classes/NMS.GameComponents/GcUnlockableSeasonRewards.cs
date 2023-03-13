using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableSeasonRewards : NMSTemplate
{
	public VirtualList<GcUnlockableSeasonReward> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcUnlockableSeasonReward>(address + GetOffset()));
		set => TrySetValue<GcUnlockableSeasonReward>(value);
	}

	public GcUnlockableSeasonRewards(long address) : base(address)
	{

	}
}
