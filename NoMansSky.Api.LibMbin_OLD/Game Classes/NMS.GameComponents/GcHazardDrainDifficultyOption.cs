using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHazardDrainDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum HazardDrainDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum>(value);
	}

	public GcHazardDrainDifficultyOption(long address) : base(address)
	{

	}
}
