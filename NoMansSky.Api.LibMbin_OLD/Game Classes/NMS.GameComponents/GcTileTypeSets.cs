using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTileTypeSets : NMSTemplate
{
	public VirtualList<GcTileTypeSet> TileTypeSets
	{
		get => cache.GetOrAddValue(new VirtualList<GcTileTypeSet>(address + GetOffset()));
		set => TrySetValue<GcTileTypeSet>(value);
	}

	public GcTileTypeSets(long address) : base(address)
	{

	}
}
