using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryStackLimitsDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum InventoryStackLimitsDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum>(value);
	}

	public GcInventoryStackLimitsDifficultyOption(long address) : base(address)
	{

	}
}
