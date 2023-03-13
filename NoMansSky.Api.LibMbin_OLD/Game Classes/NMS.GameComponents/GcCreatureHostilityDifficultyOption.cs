using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureHostilityDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureHostilityDifficultyOption.CreatureHostilityDifficultyEnum CreatureHostilityDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureHostilityDifficultyOption.CreatureHostilityDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureHostilityDifficultyOption.CreatureHostilityDifficultyEnum>(value);
	}

	public GcCreatureHostilityDifficultyOption(long address) : base(address)
	{

	}
}
