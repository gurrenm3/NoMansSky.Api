using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActiveSurvivalBarsDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcActiveSurvivalBarsDifficultyOption.ActiveSurvivalBarsDifficultyEnum ActiveSurvivalBarsDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcActiveSurvivalBarsDifficultyOption.ActiveSurvivalBarsDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcActiveSurvivalBarsDifficultyOption.ActiveSurvivalBarsDifficultyEnum>(value);
	}

	public GcActiveSurvivalBarsDifficultyOption(long address) : base(address)
	{

	}
}
