using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTraderFlyby : NMSTemplate
{
	public Int32 ExperienceSpawnIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRewardTraderFlyby(long address) : base(address)
	{

	}
}
