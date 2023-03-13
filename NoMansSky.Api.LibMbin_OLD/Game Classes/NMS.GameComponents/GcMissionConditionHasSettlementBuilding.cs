using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasSettlementBuilding : NMSTemplate
{
	public GcBuildingClassification BuildingClass
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public Boolean RequireComplete
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasSettlementBuilding(long address) : base(address)
	{

	}
}
