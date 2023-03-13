using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBreakTechOnDamageDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum BreakTechOnDamageProbability
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum>(value);
	}

	public GcBreakTechOnDamageDifficultyOption(long address) : base(address)
	{

	}
}
