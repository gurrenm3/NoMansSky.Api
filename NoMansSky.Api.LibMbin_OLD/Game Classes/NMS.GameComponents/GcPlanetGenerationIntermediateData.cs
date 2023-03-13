using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetGenerationIntermediateData : NMSTemplate
{
	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Int32 TerrainSettingIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcGalaxyStarTypes StarType
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public GcPlanetClass Class
	{
		get => GetValue<GcPlanetClass>();
		set => TrySetValue<GcPlanetClass>(value);
	}

	public GcPlanetSize Size
	{
		get => GetValue<GcPlanetSize>();
		set => TrySetValue<GcPlanetSize>(value);
	}

	public GcCreatureRoleDataTable CreatureRoles
	{
		get => GetValue<GcCreatureRoleDataTable>();
		set => TrySetValue<GcCreatureRoleDataTable>(value);
	}

	public GcTerrainControls Terrain
	{
		get => GetValue<GcTerrainControls>();
		set => TrySetValue<GcTerrainControls>(value);
	}

	public GcBiomeType Biome
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public GcBiomeSubType BiomeSubType
	{
		get => GetValue<GcBiomeSubType>();
		set => TrySetValue<GcBiomeSubType>(value);
	}

	public NMSString0x80 TerrainFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CreatureLandFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CreatureCaveFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CreatureWaterFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CreatureExtraWaterFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CreatureAirFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CreatureRobotFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcExternalObjectListOptions> ExternalObjectLists
	{
		get => cache.GetOrAddValue(new VirtualList<GcExternalObjectListOptions>(address + GetOffset()));
		set => TrySetValue<GcExternalObjectListOptions>(value);
	}

	public VirtualList<Int32> ExternalObjectListIndices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public Boolean Prime
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlanetGenerationIntermediateData(long address) : base(address)
	{

	}
}
