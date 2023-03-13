using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetaryMappingTable : NMSTemplate
{
	public VirtualArray<GcPlanetaryMappingValues> MappingInfo
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlanetaryMappingValues>(address + GetOffset(), 4));
		set => TrySetValue<GcPlanetaryMappingValues>(value);
	}

	public GcPlanetaryMappingTable(long address) : base(address)
	{

	}
}
