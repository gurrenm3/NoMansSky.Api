using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionInCombat : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionInCombat.CombatTypeEnum CombatType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionInCombat.CombatTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionInCombat.CombatTypeEnum>(value);
	}

	public NMSString0x20A OverrideOSDMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean CheckAllFireteamMembers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EncouragesFightingSentinels
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionInCombat(long address) : base(address)
	{

	}
}
