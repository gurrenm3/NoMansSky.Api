using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementBuildingCost : NMSTemplate
{
	public VirtualArray<GcSettlementBuildingCostData> StageCosts
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSettlementBuildingCostData>(address + GetOffset(), 6));
		set => TrySetValue<GcSettlementBuildingCostData>(value);
	}

	public GcSettlementBuildingCost(long address) : base(address)
	{

	}
}
