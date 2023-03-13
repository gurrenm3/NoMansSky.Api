using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSpaceshipEngineData : NMSTemplate
{
	public Single ThrustForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Falloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSpeedForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostThrustForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostingTurnDamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrakeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ReverseBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OverspeedBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowSpeedTurnDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnBrakeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnBrakeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RollAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RollForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RollAutoTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BalanceTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BalanceTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowProportionalGain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowDerivativeGain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowIntegralGain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowProportionalLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowDerivativeLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowIntegralLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowIntegralDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerSpaceshipEngineData(long address) : base(address)
	{

	}
}
