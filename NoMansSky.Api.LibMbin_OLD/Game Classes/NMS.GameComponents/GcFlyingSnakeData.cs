using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFlyingSnakeData : NMSTemplate
{
	public Single CircleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ApproachBaitSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultCircleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BarrelRollSpawnDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BarrelRollCount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BarrelRollSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RiseDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RiseHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RiseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AirThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TailStiffness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TwistLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltitudeSinPeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltitudeSinAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AscendDescendSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFlyingSnakeData(long address) : base(address)
	{

	}
}
