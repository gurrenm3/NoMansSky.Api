using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingDefinitionTable : NMSTemplate
{
	public VirtualArray<GcBuildingFilenameList> BuildingFiles
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBuildingFilenameList>(address + GetOffset(), 8));
		set => TrySetValue<GcBuildingFilenameList>(value);
	}

	public VirtualArray<GcBuildingDefinitionData> BuildingPlacement
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBuildingDefinitionData>(address + GetOffset(), 52));
		set => TrySetValue<GcBuildingDefinitionData>(value);
	}

	public VirtualList<GcBuildingClusterLayout> ClusterLayouts
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingClusterLayout>(address + GetOffset()));
		set => TrySetValue<GcBuildingClusterLayout>(value);
	}

	public GcBuildingDefinitionTable(long address) : base(address)
	{

	}
}
