using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionFactionRank : NMSTemplate
{
	public GcMissionFaction Faction
	{
		get => GetValue<GcMissionFaction>();
		set => TrySetValue<GcMissionFaction>(value);
	}

	public Boolean UseSystemRace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 Rank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionFactionRank(long address) : base(address)
	{

	}
}
