using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardOverridePulseEncounterChance : NMSTemplate
{
	public Single Chance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRewardOverridePulseEncounterChance(long address) : base(address)
	{

	}
}
