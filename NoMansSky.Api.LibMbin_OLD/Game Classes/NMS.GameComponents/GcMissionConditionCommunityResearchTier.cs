using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionCommunityResearchTier : NMSTemplate
{
	public Single CompletedTiers
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionIndex
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public Boolean TakeTierFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionCommunityResearchTier(long address) : base(address)
	{

	}
}
