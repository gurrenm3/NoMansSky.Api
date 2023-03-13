using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcItemShopAvailabilityDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum ItemShopAvailabilityDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum>(value);
	}

	public GcItemShopAvailabilityDifficultyOption(long address) : base(address)
	{

	}
}
