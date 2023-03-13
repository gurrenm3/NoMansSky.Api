using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDeathConsequencesDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDeathConsequencesDifficultyOption.DeathConsequencesDifficultyEnum DeathConsequencesDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDeathConsequencesDifficultyOption.DeathConsequencesDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDeathConsequencesDifficultyOption.DeathConsequencesDifficultyEnum>(value);
	}

	public GcDeathConsequencesDifficultyOption(long address) : base(address)
	{

	}
}
