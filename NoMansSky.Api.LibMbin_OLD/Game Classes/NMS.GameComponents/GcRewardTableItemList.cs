using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTableItemList : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardTableItemList.RewardChoiceEnum RewardChoice
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardTableItemList.RewardChoiceEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardTableItemList.RewardChoiceEnum>(value);
	}

	public Boolean OverrideZeroSeed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseInventoryChoiceOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcRewardTableItem> List
	{
		get => cache.GetOrAddValue(new VirtualList<GcRewardTableItem>(address + GetOffset()));
		set => TrySetValue<GcRewardTableItem>(value);
	}

	public GcRewardTableItemList(long address) : base(address)
	{

	}
}
