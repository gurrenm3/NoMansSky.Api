using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDroneData : NMSTemplate
{
	public GcDroneControlData Patrol
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData Attack
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData Search
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData Scan
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData Repair
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData Summon
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData ToCover
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData Stun
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData Friendly
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public GcDroneControlData FriendlyFast
	{
		get => GetValue<GcDroneControlData>();
		set => TrySetValue<GcDroneControlData>(value);
	}

	public Single CollisionAvoidOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolDistanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolDistanceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolTargetDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolInspectDistanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolInspectDistanceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolInspectTargetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolInspectSwitchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolInspectRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolRepelDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolRepelStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolHonkRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolHonkTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 DronePatrolHonkProbability
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DroneAlertTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMoveLookDistanceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMoveLookDistanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackActivateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBobAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBobRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMoveMinChoiceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMoveAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMaxDistanceFromAlert
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackAlertFailTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour EyeColourAlert
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour EyeColourSearch
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour EyeColourPatrol
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public NMSString0x10 DamageEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single DamageEffectHealthPercentThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HideBehindCoverHealthPercentThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HideBehindCoverSearchRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableCoverPlacement
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CoverPlacementActivateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoverPlacementActivateTimeMaxRandomExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoverPlacementCooldownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoverPlacementMinDistanceFromTarget
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoverPlacementMinDistanceFromSelf
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoverPlacementMaxDistanceFromSelf
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoverPlacementUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CoverPlacementMaxActiveCover
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSentinelResource CoverResource
	{
		get => GetValue<GcSentinelResource>();
		set => TrySetValue<GcSentinelResource>(value);
	}

	public Single DroneSearchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchPauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchCriminalScanRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchCriminalScanRadiusWanted
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchCriminalScanRadiusInShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneScanPlayerTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanSpeedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EyeOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EyeFocusTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 EyeNumRandomsMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 EyeNumRandomsMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single EyeTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EyeTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EyeAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineDirSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineDirAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDroneData(long address) : base(address)
	{

	}
}
