using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarGenerationGlobals : NMSTemplate
{
	public Boolean MassiveSolarSystems
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f SolarSystemSize
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single SolarSystemMaximumRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolarSystemMaximumRadiusMassive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GenerateMaximumSolarSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 GenerateForcedNumberPlanets
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseSingleRacePerSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f PerPlanetGenerationAngleChangeDegreesRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f PerPlanetGenerationElevationChangeDegreesRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SpawnPointStationToPlanetInterpRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualArray<Single> ExtremePlanetChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single StationSpawnAvoidRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 LocatorScatterMinCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LocatorScatterMaxCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single LocatorScatterMaxDistanceFromPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 LocatorScatterChanceOfCapitalShips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LocatorScatterChanceOfPirates
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PlanetInvalidAsteroidZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AsteroidsEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SparseAsteroidSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcAsteroidSystemGenerationData> AsteroidSettings
	{
		get => cache.GetOrAddValue(new VirtualList<GcAsteroidSystemGenerationData>(address + GetOffset()));
		set => TrySetValue<GcAsteroidSystemGenerationData>(value);
	}

	public Vector2f RareAsteroidNoiseRangeSomeRares
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f RareAsteroidNoiseRangeLotsOfRares
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single RareAsteroidSystemOddsYellow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RareAsteroidSystemOddsGreen
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RareAsteroidSystemOddsBlue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RareAsteroidSystemOddsRed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AsteroidsCheckNoise
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 AsteroidNoiseOctaves
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkCurveType AsteroidScaleVarianceCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single AsteroidSomeRaresOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidLotsOfRaresOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 RareAsteroidMinResources
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RareAsteroidMaxResources
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 RareAsteroidResource
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 CommonAsteroidMinResources
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CommonAsteroidMaxResources
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FuelAsteroidMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CommonAsteroidResourceFuelMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 CommonAsteroidResourceFuel
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RareAsteroidResourceFuel
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 CommonAsteroidResourceProduct
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 CommonAsteroidResourceMain
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 CommonAsteroidResourceSecondary
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RareAsteroidDataProduct
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CommonAsteroidResourceFuelOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RareAsteroidResourceFuelOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommonAsteroidResourceProductOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RareAsteroidDataProductOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommonAsteroidResourceSecondaryOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeAsteroidFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidSpaceStationAvoidRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidAnomalyAvoidRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidWarpInAreaAvoidRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidCreatureRichSystemProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> AbandonedSystemProbability
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> EmptySystemProbability
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> PirateSystemProbability
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Int32 CivilianTraderSpaceshipsCacheCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Single> SpaceshipSpawnFreqMultipliers
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcAISpaceshipWeightingData> SpaceshipWeightings
	{
		get => cache.GetOrAddValue(new VirtualList<GcAISpaceshipWeightingData>(address + GetOffset()));
		set => TrySetValue<GcAISpaceshipWeightingData>(value);
	}

	public Single PirateClassShipOverrideProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateClassShipOverrideProbabilityPirateSystem
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetRingProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlanetRingData PlanetRingsMin
	{
		get => GetValue<GcPlanetRingData>();
		set => TrySetValue<GcPlanetRingData>(value);
	}

	public GcPlanetRingData PlanetRingsMax
	{
		get => GetValue<GcPlanetRingData>();
		set => TrySetValue<GcPlanetRingData>(value);
	}

	public Int32 PercentChanceExtraPrime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSolarGenerationGlobals(long address) : base(address)
	{

	}
}
