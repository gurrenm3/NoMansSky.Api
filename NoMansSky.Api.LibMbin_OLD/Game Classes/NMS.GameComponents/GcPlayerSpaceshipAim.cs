using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSpaceshipAim : NMSTemplate
{
	public Single AimAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDistanceAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDistanceAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDistanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDistanceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerSpaceshipAim(long address) : base(address)
	{

	}
}
