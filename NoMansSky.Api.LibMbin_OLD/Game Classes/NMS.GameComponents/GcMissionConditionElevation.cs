using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionElevation : NMSTemplate
{
	public Single HeightAboveSea
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AllowInShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TakeAmountFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionElevation(long address) : base(address)
	{

	}
}
