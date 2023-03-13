using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardBeginSettlementBuilding : NMSTemplate
{
	public VirtualList<GcBuildingClassification> ValidBuildings
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingClassification>(address + GetOffset()));
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public GcRewardBeginSettlementBuilding(long address) : base(address)
	{

	}
}
