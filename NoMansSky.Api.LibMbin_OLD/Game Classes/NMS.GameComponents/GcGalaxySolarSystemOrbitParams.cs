using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxySolarSystemOrbitParams : NMSTemplate
{
	public Single FirstOrbitRadiusMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstOrbitRadiusMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OrbitRadiusOffsetMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OrbitRadiusOffsetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OrbitRotationSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OrbitRotationSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OrbitLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGalaxySolarSystemOrbitParams(long address) : base(address)
	{

	}
}
