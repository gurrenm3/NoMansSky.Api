using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProjectileDataTable : NMSTemplate
{
	public VirtualList<GcProjectileData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcProjectileData>(address + GetOffset()));
		set => TrySetValue<GcProjectileData>(value);
	}

	public VirtualList<GcLaserBeamData> Lasers
	{
		get => cache.GetOrAddValue(new VirtualList<GcLaserBeamData>(address + GetOffset()));
		set => TrySetValue<GcLaserBeamData>(value);
	}

	public GcProjectileDataTable(long address) : base(address)
	{

	}
}
