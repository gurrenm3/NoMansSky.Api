using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainTileType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcTerrainTileType.TileTypeEnum TileType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTerrainTileType.TileTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTerrainTileType.TileTypeEnum>(value);
	}

	public GcTerrainTileType(long address) : base(address)
	{

	}
}
