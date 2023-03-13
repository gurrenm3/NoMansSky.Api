using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardFactionStanding : NMSTemplate
{
	public GcMissionFaction Faction
	{
		get => GetValue<GcMissionFaction>();
		set => TrySetValue<GcMissionFaction>(value);
	}

	public Int32 AmountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AmountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean SetToMinBeforeAdd
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardFactionStanding(long address) : base(address)
	{

	}
}
