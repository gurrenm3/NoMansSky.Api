using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcChargingRequirementsDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum ChargingRequirementsDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum>(value);
	}

	public GcChargingRequirementsDifficultyOption(long address) : base(address)
	{

	}
}
