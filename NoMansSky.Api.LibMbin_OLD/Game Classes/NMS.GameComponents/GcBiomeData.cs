using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeData : NMSTemplate
{
	public NMSString0x80 TextureFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 OverlayFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 TileTypesFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ColourPaletteFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 LegacyColourPaletteFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMiningSubstanceData MiningSubstance1
	{
		get => GetValue<GcMiningSubstanceData>();
		set => TrySetValue<GcMiningSubstanceData>(value);
	}

	public GcMiningSubstanceData MiningSubstance2
	{
		get => GetValue<GcMiningSubstanceData>();
		set => TrySetValue<GcMiningSubstanceData>(value);
	}

	public GcMiningSubstanceData MiningSubstance3
	{
		get => GetValue<GcMiningSubstanceData>();
		set => TrySetValue<GcMiningSubstanceData>(value);
	}

	public Single FuelMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlanetWaterData Water
	{
		get => GetValue<GcPlanetWaterData>();
		set => TrySetValue<GcPlanetWaterData>(value);
	}

	public VirtualList<GcExternalObjectListOptions> ExternalObjectLists
	{
		get => cache.GetOrAddValue(new VirtualList<GcExternalObjectListOptions>(address + GetOffset()));
		set => TrySetValue<GcExternalObjectListOptions>(value);
	}

	public VirtualArray<GcWeatherWeightings> WeatherOptions
	{
		get => cache.GetOrAddValue(new VirtualArray<GcWeatherWeightings>(address + GetOffset(), 4));
		set => TrySetValue<GcWeatherWeightings>(value);
	}

	public Vector2f WeatherChangeTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcBiomeCloudSettings CloudSettings
	{
		get => GetValue<GcBiomeCloudSettings>();
		set => TrySetValue<GcBiomeCloudSettings>(value);
	}

	public GcTerrainControls Terrain
	{
		get => GetValue<GcTerrainControls>();
		set => TrySetValue<GcTerrainControls>(value);
	}

	public VirtualList<GcScreenFilterOption> FilterOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcScreenFilterOption>(address + GetOffset()));
		set => TrySetValue<GcScreenFilterOption>(value);
	}

	public NMSString0x20A FloraLifeLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcBiomeData(long address) : base(address)
	{

	}
}
