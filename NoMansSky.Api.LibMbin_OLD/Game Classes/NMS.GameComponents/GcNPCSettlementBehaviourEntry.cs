using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourEntry : NMSTemplate
{
	public Single RunWhenOutdoorsProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean OnlyUseIndoorPOIs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcNPCSettlementBehaviourBuildingClassCapacityEntry> BuildingClassCapacities
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCSettlementBehaviourBuildingClassCapacityEntry>(address + GetOffset()));
		set => TrySetValue<GcNPCSettlementBehaviourBuildingClassCapacityEntry>(value);
	}

	public VirtualList<GcNPCSettlementBehaviourAreaPropertyWeightEntry> AreaPropertyWeights
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCSettlementBehaviourAreaPropertyWeightEntry>(address + GetOffset()));
		set => TrySetValue<GcNPCSettlementBehaviourAreaPropertyWeightEntry>(value);
	}

	public VirtualList<GcNPCSettlementBehaviourBuildingClassWeightEntry> BuildingClassWeights
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCSettlementBehaviourBuildingClassWeightEntry>(address + GetOffset()));
		set => TrySetValue<GcNPCSettlementBehaviourBuildingClassWeightEntry>(value);
	}

	public VirtualList<GcNPCSettlementBehaviourObjectTypeWeightEntry> ObjectTypeWeights
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCSettlementBehaviourObjectTypeWeightEntry>(address + GetOffset()));
		set => TrySetValue<GcNPCSettlementBehaviourObjectTypeWeightEntry>(value);
	}

	public GcNPCSettlementBehaviourEntry(long address) : base(address)
	{

	}
}
