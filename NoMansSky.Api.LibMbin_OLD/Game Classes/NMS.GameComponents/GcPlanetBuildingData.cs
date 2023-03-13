using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetBuildingData : NMSTemplate
{
	public VirtualList<GcBuildingSpawnSlot> BuildingSlots
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingSpawnSlot>(address + GetOffset()));
		set => TrySetValue<GcBuildingSpawnSlot>(value);
	}

	public VirtualList<GcBuildingSpawnData> Buildings
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingSpawnData>(address + GetOffset()));
		set => TrySetValue<GcBuildingSpawnData>(value);
	}

	public VirtualList<GcBuildingOverrideData> OverrideBuildings
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingOverrideData>(address + GetOffset()));
		set => TrySetValue<GcBuildingOverrideData>(value);
	}

	public Single Spacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VoronoiPointDivisions
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 VoronoiSectorSeed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 VoronoiPointSeed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean InitialBuildingsPlaced
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsPrime
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlanetBuildingData(long address) : base(address)
	{

	}
}
