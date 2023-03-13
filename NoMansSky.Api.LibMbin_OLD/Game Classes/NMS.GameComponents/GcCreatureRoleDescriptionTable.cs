using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoleDescriptionTable : NMSTemplate
{
	public VirtualList<GcCreatureRoleDescription> RoleDescription
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureRoleDescription>(address + GetOffset()));
		set => TrySetValue<GcCreatureRoleDescription>(value);
	}

	public Single MinScaleVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxScaleVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTerrainTileType TileType
	{
		get => GetValue<GcTerrainTileType>();
		set => TrySetValue<GcTerrainTileType>(value);
	}

	public GcPlanetLife LifeLevel
	{
		get => GetValue<GcPlanetLife>();
		set => TrySetValue<GcPlanetLife>(value);
	}

	public GcCreatureRoleDescriptionTable(long address) : base(address)
	{

	}
}
