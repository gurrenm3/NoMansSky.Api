using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVoxelGeneratorData : NMSTemplate
{
	public GcSeed BaseSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Single SeaLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BeachHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoSeaBaseLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseVoxelTypeEnum BuildingVoxelType
	{
		get => GetValue<TkNoiseVoxelTypeEnum>();
		set => TrySetValue<TkNoiseVoxelTypeEnum>(value);
	}

	public TkNoiseVoxelTypeEnum ResourceVoxelType
	{
		get => GetValue<TkNoiseVoxelTypeEnum>();
		set => TrySetValue<TkNoiseVoxelTypeEnum>(value);
	}

	public VirtualArray<TkNoiseUberLayerData> NoiseLayers
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNoiseUberLayerData>(address + GetOffset(), 8));
		set => TrySetValue<TkNoiseUberLayerData>(value);
	}

	public VirtualArray<TkNoiseGridData> GridLayers
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNoiseGridData>(address + GetOffset(), 9));
		set => TrySetValue<TkNoiseGridData>(value);
	}

	public VirtualArray<TkNoiseFeatureData> Features
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNoiseFeatureData>(address + GetOffset(), 7));
		set => TrySetValue<TkNoiseFeatureData>(value);
	}

	public VirtualArray<TkNoiseCaveData> Caves
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNoiseCaveData>(address + GetOffset(), 1));
		set => TrySetValue<TkNoiseCaveData>(value);
	}

	public Single MinimumCaveDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CaveRoofSmoothingDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaximumSeaLevelCaveDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingTextureRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingSmoothingRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingSmoothingHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterFadeInDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkVoxelGeneratorData(long address) : base(address)
	{

	}
}
