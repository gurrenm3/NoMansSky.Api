using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemData : NMSTemplate
{
	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcSolarSystemClass Class
	{
		get => GetValue<GcSolarSystemClass>();
		set => TrySetValue<GcSolarSystemClass>(value);
	}

	public GcGalaxyStarTypes StarType
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public Int32 Planets
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Vector3f> PlanetPositions
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector3f>(address + GetOffset(), 8));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualArray<GcPlanetGenerationInputData> PlanetGenerationInputs
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlanetGenerationInputData>(address + GetOffset(), 8));
		set => TrySetValue<GcPlanetGenerationInputData>(value);
	}

	public VirtualArray<Int32> PlanetOrbits
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 8));
		set => TrySetValue<Int32>(value);
	}

	public Int32 PrimePlanets
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f SunPosition
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public NMSString0x10 AsteroidSubstanceID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 NumTradeRoutes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumVisibleTradeRoutes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxNumFreighters
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean StartWithFreighters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f FreighterTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SpacePirateTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f PlanetPirateTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f FlybyTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f PoliceTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcSpaceStationSpawnData SpaceStationSpawn
	{
		get => GetValue<GcSpaceStationSpawnData>();
		set => TrySetValue<GcSpaceStationSpawnData>(value);
	}

	public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts
	{
		get => GetValue<GcSolarSystemTraderSpawnData>();
		set => TrySetValue<GcSolarSystemTraderSpawnData>(value);
	}

	public GcSolarSystemTraderSpawnData TraderSpawnInStations
	{
		get => GetValue<GcSolarSystemTraderSpawnData>();
		set => TrySetValue<GcSolarSystemTraderSpawnData>(value);
	}

	public VirtualList<GcSolarSystemLocator> Locators
	{
		get => cache.GetOrAddValue(new VirtualList<GcSolarSystemLocator>(address + GetOffset()));
		set => TrySetValue<GcSolarSystemLocator>(value);
	}

	public VirtualList<NMSTemplate> AsteroidGenerators
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public libMBIN.NMS.GameComponents.GcSolarSystemData.AsteroidLevelEnum AsteroidLevel
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSolarSystemData.AsteroidLevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSolarSystemData.AsteroidLevelEnum>(value);
	}

	public GcPlanetColourData Colours
	{
		get => GetValue<GcPlanetColourData>();
		set => TrySetValue<GcPlanetColourData>(value);
	}

	public GcLightProperties Light
	{
		get => GetValue<GcLightProperties>();
		set => TrySetValue<GcLightProperties>(value);
	}

	public GcSpaceSkyProperties Sky
	{
		get => GetValue<GcSpaceSkyProperties>();
		set => TrySetValue<GcSpaceSkyProperties>(value);
	}

	public GcScreenFilters ScreenFilter
	{
		get => GetValue<GcScreenFilters>();
		set => TrySetValue<GcScreenFilters>(value);
	}

	public NMSString0x80 HeavyAir
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcAISpaceshipPreloadCacheData> SystemShips
	{
		get => cache.GetOrAddValue(new VirtualList<GcAISpaceshipPreloadCacheData>(address + GetOffset()));
		set => TrySetValue<GcAISpaceshipPreloadCacheData>(value);
	}

	public GcAlienRace InhabitingRace
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public GcPlanetTradingData TradingData
	{
		get => GetValue<GcPlanetTradingData>();
		set => TrySetValue<GcPlanetTradingData>(value);
	}

	public GcPlayerConflictData ConflictData
	{
		get => GetValue<GcPlayerConflictData>();
		set => TrySetValue<GcPlayerConflictData>(value);
	}

	public GcSolarSystemData(long address) : base(address)
	{

	}
}
