using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetSkyProperties : NMSTemplate
{
	public GcSkyProperties PlanetSky
	{
		get => GetValue<GcSkyProperties>();
		set => TrySetValue<GcSkyProperties>(value);
	}

	public GcFogProperties PlanetFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcFogProperties PlanetExtremeFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcFogProperties PlanetStormFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcFogProperties PlanetFlightFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcPlanetSkyProperties(long address) : base(address)
	{

	}
}
