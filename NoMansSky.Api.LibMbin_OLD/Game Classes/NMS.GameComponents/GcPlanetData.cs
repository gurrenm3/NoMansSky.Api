using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetData : NMSTemplate
{
	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcPlanetLife Life
	{
		get => GetValue<GcPlanetLife>();
		set => TrySetValue<GcPlanetLife>(value);
	}

	public GcPlanetLife CreatureLife
	{
		get => GetValue<GcPlanetLife>();
		set => TrySetValue<GcPlanetLife>(value);
	}

	public GcPlanetHazardData Hazard
	{
		get => GetValue<GcPlanetHazardData>();
		set => TrySetValue<GcPlanetHazardData>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlanetData.ResourceLevelEnum ResourceLevel
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetData.ResourceLevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetData.ResourceLevelEnum>(value);
	}

	public GcBuildingDensityLevels BuildingLevel
	{
		get => GetValue<GcBuildingDensityLevels>();
		set => TrySetValue<GcBuildingDensityLevels>(value);
	}

	public NMSString0x10 CommonSubstanceID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 UncommonSubstanceID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RareSubstanceID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcPlanetDataResourceHint> ExtraResourceHints
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlanetDataResourceHint>(address + GetOffset()));
		set => TrySetValue<GcPlanetDataResourceHint>(value);
	}

	public GcPlanetColourData Colours
	{
		get => GetValue<GcPlanetColourData>();
		set => TrySetValue<GcPlanetColourData>(value);
	}

	public VirtualArray<Colour> TileColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 23));
		set => TrySetValue<Colour>(value);
	}

	public GcPlanetWeatherData Weather
	{
		get => GetValue<GcPlanetWeatherData>();
		set => TrySetValue<GcPlanetWeatherData>(value);
	}

	public GcPlanetCloudProperties Clouds
	{
		get => GetValue<GcPlanetCloudProperties>();
		set => TrySetValue<GcPlanetCloudProperties>(value);
	}

	public GcPlanetWaterData Water
	{
		get => GetValue<GcPlanetWaterData>();
		set => TrySetValue<GcPlanetWaterData>(value);
	}

	public NMSString0x80 TerrainFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkVoxelGeneratorData Terrain
	{
		get => GetValue<TkVoxelGeneratorData>();
		set => TrySetValue<TkVoxelGeneratorData>(value);
	}

	public Int32 TileTypeSet
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> TileTypeIndices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public GcEnvironmentSpawnData SpawnData
	{
		get => GetValue<GcEnvironmentSpawnData>();
		set => TrySetValue<GcEnvironmentSpawnData>(value);
	}

	public GcAlienRace InhabitingRace
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public GcPlanetBuildingData BuildingData
	{
		get => GetValue<GcPlanetBuildingData>();
		set => TrySetValue<GcPlanetBuildingData>(value);
	}

	public GcPlanetGenerationIntermediateData GenerationData
	{
		get => GetValue<GcPlanetGenerationIntermediateData>();
		set => TrySetValue<GcPlanetGenerationIntermediateData>(value);
	}

	public Vector2f SentinelTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f FlybyTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcPlanetInfo PlanetInfo
	{
		get => GetValue<GcPlanetInfo>();
		set => TrySetValue<GcPlanetInfo>(value);
	}

	public GcPlanetSentinelData SentinelData
	{
		get => GetValue<GcPlanetSentinelData>();
		set => TrySetValue<GcPlanetSentinelData>(value);
	}

	public GcPlanetRingData Rings
	{
		get => GetValue<GcPlanetRingData>();
		set => TrySetValue<GcPlanetRingData>(value);
	}

	public Boolean InEmptySystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InAbandonedSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FuelMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlanetData(long address) : base(address)
	{

	}
}
