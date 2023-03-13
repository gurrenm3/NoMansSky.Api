using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionNearestBuilding : NMSTemplate
{
	public GcBuildingClassification Building
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcBuildingClassification> AdditionalBuildings
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingClassification>(address + GetOffset()));
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public GcMissionConditionNearestBuilding(long address) : base(address)
	{

	}
}
