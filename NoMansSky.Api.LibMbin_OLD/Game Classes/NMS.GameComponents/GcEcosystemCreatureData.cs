using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEcosystemCreatureData : NMSTemplate
{
	public NMSString0x10 Creature
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcTerrainTileType TileType
	{
		get => GetValue<GcTerrainTileType>();
		set => TrySetValue<GcTerrainTileType>(value);
	}

	public Single MinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Rarity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcEcosystemCreatureData(long address) : base(address)
	{

	}
}
