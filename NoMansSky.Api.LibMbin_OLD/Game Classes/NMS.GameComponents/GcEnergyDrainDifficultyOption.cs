using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEnergyDrainDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum EnergyDrainDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum>(value);
	}

	public GcEnergyDrainDifficultyOption(long address) : base(address)
	{

	}
}
