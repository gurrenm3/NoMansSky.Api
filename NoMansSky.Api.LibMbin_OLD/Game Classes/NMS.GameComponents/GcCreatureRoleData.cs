using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoleData : NMSTemplate
{
	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcCreatureTypes Type
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public NMSString0x10 CreatureId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCreatureRoleDescription Description
	{
		get => GetValue<GcCreatureRoleDescription>();
		set => TrySetValue<GcCreatureRoleDescription>(value);
	}

	public GcCreatureInfo Info
	{
		get => GetValue<GcCreatureInfo>();
		set => TrySetValue<GcCreatureInfo>(value);
	}

	public GcTerrainTileType TileType
	{
		get => GetValue<GcTerrainTileType>();
		set => TrySetValue<GcTerrainTileType>(value);
	}

	public GcCreatureDiet Diet
	{
		get => GetValue<GcCreatureDiet>();
		set => TrySetValue<GcCreatureDiet>(value);
	}

	public Single GroupsPerSquareKm
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureHemiSphere HemiSphere
	{
		get => GetValue<GcCreatureHemiSphere>();
		set => TrySetValue<GcCreatureHemiSphere>(value);
	}

	public NMSString0x20A Filter
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCreatureRoleData(long address) : base(address)
	{

	}
}
