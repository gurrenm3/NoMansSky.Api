using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCurrencyCostDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum CurrencyCostDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum>(value);
	}

	public GcCurrencyCostDifficultyOption(long address) : base(address)
	{

	}
}
