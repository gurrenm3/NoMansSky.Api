using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCombatTimerDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum CombatTimerDifficultyOption
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum>(value);
	}

	public GcCombatTimerDifficultyOption(long address) : base(address)
	{

	}
}
