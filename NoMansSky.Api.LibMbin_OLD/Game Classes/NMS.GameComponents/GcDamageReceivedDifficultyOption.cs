using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDamageReceivedDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum DamageReceivedDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum>(value);
	}

	public GcDamageReceivedDifficultyOption(long address) : base(address)
	{

	}
}
