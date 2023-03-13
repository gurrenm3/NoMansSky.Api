using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceshipAvoidanceData : NMSTemplate
{
	public Int32 NumRays
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single RayMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaySpeedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Force
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EndRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedInterp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedInterpMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedInterpRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSpaceshipAvoidanceData(long address) : base(address)
	{

	}
}
