using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFuelUseDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFuelUseDifficultyOption.FuelUseDifficultyEnum FuelUseDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFuelUseDifficultyOption.FuelUseDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFuelUseDifficultyOption.FuelUseDifficultyEnum>(value);
	}

	public GcFuelUseDifficultyOption(long address) : base(address)
	{

	}
}
