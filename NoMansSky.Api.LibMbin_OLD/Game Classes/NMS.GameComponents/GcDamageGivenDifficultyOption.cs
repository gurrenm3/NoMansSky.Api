using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDamageGivenDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum DamageGivenDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum>(value);
	}

	public GcDamageGivenDifficultyOption(long address) : base(address)
	{

	}
}
