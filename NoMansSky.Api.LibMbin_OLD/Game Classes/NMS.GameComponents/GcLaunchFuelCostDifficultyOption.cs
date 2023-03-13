using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLaunchFuelCostDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum LaunchFuelCostDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum>(value);
	}

	public GcLaunchFuelCostDifficultyOption(long address) : base(address)
	{

	}
}
