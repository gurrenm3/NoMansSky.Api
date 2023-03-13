using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcObjectSpawnDataArray : NMSTemplate
{
	public GcTerrainTileType TileType
	{
		get => GetValue<GcTerrainTileType>();
		set => TrySetValue<GcTerrainTileType>(value);
	}

	public Int32 MaxObjectsToSpawn
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcObjectSpawnData> Objects
	{
		get => cache.GetOrAddValue(new VirtualList<GcObjectSpawnData>(address + GetOffset()));
		set => TrySetValue<GcObjectSpawnData>(value);
	}

	public GcObjectSpawnDataArray(long address) : base(address)
	{

	}
}
