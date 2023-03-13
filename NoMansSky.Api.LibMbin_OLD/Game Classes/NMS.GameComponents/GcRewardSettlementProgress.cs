using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSettlementProgress : NMSTemplate
{
	public Boolean UseInteractionBuildingType
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBuildingClassification BuildingType
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public GcRewardSettlementProgress(long address) : base(address)
	{

	}
}
