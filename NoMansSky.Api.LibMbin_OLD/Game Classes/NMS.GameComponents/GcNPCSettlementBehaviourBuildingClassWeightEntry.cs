using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourBuildingClassWeightEntry : NMSTemplate
{
	public GcBuildingClassification BuildingClass
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public Single EntryWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcNPCSettlementBehaviourBuildingClassWeightEntry(long address) : base(address)
	{

	}
}
