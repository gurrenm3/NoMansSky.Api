using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasCreatureEggItem : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionHasCreatureEggItem.EggItemTypeEnum EggItemType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionHasCreatureEggItem.EggItemTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionHasCreatureEggItem.EggItemTypeEnum>(value);
	}

	public Boolean IncludeEggMachineInventoryInSearch
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasCreatureEggItem(long address) : base(address)
	{

	}
}
