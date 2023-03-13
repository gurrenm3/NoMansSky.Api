using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipAIAttackData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single GunDispersionAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunFireRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserHealthPoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackWeaponRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackShootWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackShootTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackShootTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackReadyTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackApproachOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackApproachMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackApproachMaxRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTooCloseRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFlybyOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBoostTimeToRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBoostRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBoostAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTurnMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMaxPlanetHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTurnMultiplierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTurnMaxMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTurnMaxTimeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumHitsBeforeBail
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumHitsBeforeReposition
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FleeBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeBrakeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRepositionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRepositionAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRepositionAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeUrgentBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeUrgentBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeUrgentBrakeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRepositionUrgentTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRepositionUrgentAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRepositionUrgentAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeUrgentRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetFleeHeightExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTargetMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTargetMaxRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTargetOffsetMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTargetOffsetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackTargetSwitchTargetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcShipAIAttackData(long address) : base(address)
	{

	}
}
