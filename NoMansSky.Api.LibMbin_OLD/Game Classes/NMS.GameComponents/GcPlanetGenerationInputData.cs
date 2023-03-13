using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetGenerationInputData : NMSTemplate
{
	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcGalaxyStarTypes Star
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public GcPlanetClass Class
	{
		get => GetValue<GcPlanetClass>();
		set => TrySetValue<GcPlanetClass>(value);
	}

	public NMSString0x10 CommonSubstance
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RareSubstance
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlanetSize PlanetSize
	{
		get => GetValue<GcPlanetSize>();
		set => TrySetValue<GcPlanetSize>(value);
	}

	public GcBiomeType Biome
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public GcBiomeSubType BiomeSubType
	{
		get => GetValue<GcBiomeSubType>();
		set => TrySetValue<GcBiomeSubType>(value);
	}

	public Boolean HasRings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceContinents
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InEmptySystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InAbandonedSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InPirateSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Prime
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 RealityIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPlanetGenerationInputData(long address) : base(address)
	{

	}
}
