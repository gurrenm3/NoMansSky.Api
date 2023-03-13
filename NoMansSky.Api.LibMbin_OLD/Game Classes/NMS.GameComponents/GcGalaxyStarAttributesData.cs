using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyStarAttributesData : NMSTemplate
{
	public GcGalaxyStarTypes Type
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public GcGalaxyStarAnomaly Anomaly
	{
		get => GetValue<GcGalaxyStarAnomaly>();
		set => TrySetValue<GcGalaxyStarAnomaly>(value);
	}

	public Int32 NumberOfPlanets
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumberOfPrimePlanets
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<GcPlanetSize> PlanetSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlanetSize>(address + GetOffset(), 16));
		set => TrySetValue<GcPlanetSize>(value);
	}

	public VirtualArray<Int32> PlanetParentIndices
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 16));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<GcSeed> PlanetSeeds
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSeed>(address + GetOffset(), 16));
		set => TrySetValue<GcSeed>(value);
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

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Boolean AbandonedSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsPirateSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsSystemSafe
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcGalaxyStarAttributesData(long address) : base(address)
	{

	}
}
