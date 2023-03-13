using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasProcMissionForFaction : NMSTemplate
{
	public GcMissionFaction Faction
	{
		get => GetValue<GcMissionFaction>();
		set => TrySetValue<GcMissionFaction>(value);
	}

	public GcMissionConditionHasProcMissionForFaction(long address) : base(address)
	{

	}
}
