using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourBuildingClassCapacityEntry : NMSTemplate
{
	public GcBuildingClassification BuildingClass
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public Int32 Capacity
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcNPCSettlementBehaviourBuildingClassCapacityEntry(long address) : base(address)
	{

	}
}
