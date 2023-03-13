using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpawnDensityList : NMSTemplate
{
	public VirtualList<GcSpawnDensity> DensityList
	{
		get => cache.GetOrAddValue(new VirtualList<GcSpawnDensity>(address + GetOffset()));
		set => TrySetValue<GcSpawnDensity>(value);
	}

	public GcSpawnDensityList(long address) : base(address)
	{

	}
}
