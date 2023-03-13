using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVoxelGeneratorRegionData : NMSTemplate
{
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

	public VirtualList<TkNoiseFlattenPoint> FlattenTerrainPoints
	{
		get => cache.GetOrAddValue(new VirtualList<TkNoiseFlattenPoint>(address + GetOffset()));
		set => TrySetValue<TkNoiseFlattenPoint>(value);
	}

	public VirtualList<Single> FlattenTypeChances
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Int32 WaypointIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LandingPadIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AddShelterChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> ShelterIndices
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumShelters
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkVoxelGeneratorRegionData(long address) : base(address)
	{

	}
}
