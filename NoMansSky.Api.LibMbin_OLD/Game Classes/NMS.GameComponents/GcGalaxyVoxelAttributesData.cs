using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyVoxelAttributesData : NMSTemplate
{
	public Boolean InsideGoalGap
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single UnitDistanceFromGoalEdge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionColourValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f TransitPopulationDistanceRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single TransitPopulationPerpDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GuideStarMinimumCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 GuideStarRenegadeCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BlackholeCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AtlasStationCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> BlackholeIndices
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 12));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> AtlasStationIndices
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 12));
		set => TrySetValue<Int32>(value);
	}

	public GcGalaxyVoxelAttributesData(long address) : base(address)
	{

	}
}
