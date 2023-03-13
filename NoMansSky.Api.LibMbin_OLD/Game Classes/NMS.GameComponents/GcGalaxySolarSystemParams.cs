using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxySolarSystemParams : NMSTemplate
{
	public GcGalaxySolarSystemOrbitParams PlanetParameters
	{
		get => GetValue<GcGalaxySolarSystemOrbitParams>();
		set => TrySetValue<GcGalaxySolarSystemOrbitParams>(value);
	}

	public GcGalaxySolarSystemOrbitParams MoonParameters
	{
		get => GetValue<GcGalaxySolarSystemOrbitParams>();
		set => TrySetValue<GcGalaxySolarSystemOrbitParams>(value);
	}

	public VirtualArray<Single> PlanetRadii
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single SystemTilt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VisitedPlanetAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NonVisitedPlanetAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGalaxySolarSystemParams(long address) : base(address)
	{

	}
}
