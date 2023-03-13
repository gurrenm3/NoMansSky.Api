using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSprintingCostDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum SprintingCostDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum>(value);
	}

	public GcSprintingCostDifficultyOption(long address) : base(address)
	{

	}
}
