using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEventSolarSystemLookup : NMSTemplate
{
	public Boolean UseStarType
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseWealth
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseTrading
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAlienRace UseRace
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public GcGalaxyStarAnomaly UseAnomaly
	{
		get => GetValue<GcGalaxyStarAnomaly>();
		set => TrySetValue<GcGalaxyStarAnomaly>(value);
	}

	public GcPlayerConflictData UseConflict
	{
		get => GetValue<GcPlayerConflictData>();
		set => TrySetValue<GcPlayerConflictData>(value);
	}

	public GcGalaxyStarTypes StarType
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public GcPlanetTradingData TradingData
	{
		get => GetValue<GcPlanetTradingData>();
		set => TrySetValue<GcPlanetTradingData>(value);
	}

	public Boolean AllowUnsafeMatches
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeverAllowEmpty
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeverAllowAbandoned
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RequireUndiscovered
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsWaterPlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsPrimePlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsExtremeSentinelPlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeverAllowExtremeSentinelPlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsExtremeWeatherPlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsExtremeHazardPlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AnyBiomeNotWeirdOrDead
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AnyRGBBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AnyInfestedBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBiomeType NeedsBiomeType
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public GcBiomeSubType UseBiomeSubType
	{
		get => GetValue<GcBiomeSubType>();
		set => TrySetValue<GcBiomeSubType>(value);
	}

	public Boolean NeedsEmptySystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsAbandonedSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 NeedsResourceHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean SuitableForCreatureDiscovery
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SuitableForCreatureTaming
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A SamePlanetAsEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcScanEventSolarSystemLookup(long address) : base(address)
	{

	}
}
