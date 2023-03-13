using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetaryMappingValues : NMSTemplate
{
	public GcPlanetSize PlanetSize
	{
		get => GetValue<GcPlanetSize>();
		set => TrySetValue<GcPlanetSize>(value);
	}

	public UInt16 SectionPerSide
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public UInt16 PolesPerSection
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public GcPlanetaryMappingValues(long address) : base(address)
	{

	}
}
