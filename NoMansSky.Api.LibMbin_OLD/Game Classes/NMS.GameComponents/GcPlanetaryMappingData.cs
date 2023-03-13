using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetaryMappingData : NMSTemplate
{
	public UInt64 UA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<GcPlanetSectionData> SectionsData
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlanetSectionData>(address + GetOffset()));
		set => TrySetValue<GcPlanetSectionData>(value);
	}

	public GcPlanetaryMappingData(long address) : base(address)
	{

	}
}
