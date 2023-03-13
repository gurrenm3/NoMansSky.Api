using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionFreighterBattle : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionFreighterBattle.FreighterBattleStatusEnum FreighterBattleStatus
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionFreighterBattle.FreighterBattleStatusEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionFreighterBattle.FreighterBattleStatusEnum>(value);
	}

	public Int32 FreighterBattleDistance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkEqualityEnum FreighterBattleTest
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public GcMissionConditionFreighterBattle(long address) : base(address)
	{

	}
}
