using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSquadronConfig : NMSTemplate
{
	public NMSString0x20 SquadName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualArray<Vector2f> PilotRankTraitRanges
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector2f>(address + GetOffset(), 4));
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualArray<NMSString0x10> PilotRankAttackDefinitions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single SummonArriveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonArriveTimeIntervalMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonArriveTimeIntervalMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonStartSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonLimitTurningTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSpeedForSummonInMoveDir
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonSpaceSpawnRangeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonSpaceSpawnRangeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonSpaceSpawnAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonSpaceSpawnAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonPlanetPitchMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonPlanetPitchMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonPlanetYawMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonPlanetYawMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonPlanetDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SummonInFormation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SummonInFormationFwdOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingForceScaleDistMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingForceScaleDistMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingMaxForceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingFromPlanetOrbitWarpDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingFromPlanetOrbitMinIncline
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingFromPlanetOrbitMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingFromSpaceWarpDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingFromSpaceAngleFromFwdMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeavingFromSpaceAngleFromFwdMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetRotationPeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetRotationMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetZOffsetVarianceMinSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetZOffsetVarianceMaxSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetZOffsetVariancePeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetZOffsetVarianceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetZOffsetVarianceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f FormationOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single FormationOffsetCylinderWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetCylinderHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetCylinderLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f FormationOffsetThirdPerson
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single FormationOffsetCylinderWidthThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetCylinderHeightThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FormationOffsetCylinderLengthThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f CombatFormationOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single CombatFormationOffsetCylinderWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatFormationOffsetCylinderHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatFormationOffsetCylinderLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f CombatFormationOffsetThirdPerson
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single CombatFormationOffsetCylinderWidthThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatFormationOffsetCylinderHeightThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatFormationOffsetCylinderLengthThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationStrengthVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationInCombatMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationInCombatMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationStartSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationLockStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationLockStrengthCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationLockStrengthBoosting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationPostBoostSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationLockAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationLockRollAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationAlignMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationAlignMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationAlignMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationAlignMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationSharpTurnMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintainFormationSharpTurnMinSpeedForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationArrivalTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationBoostMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationBoostMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationBoostMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationBoostAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationBrakeAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationBrakeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinFormationMaxSpeedBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BreakFormationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BreakFormationMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BreakFormationMinTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BreakFormationMaxTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeBetweenFormationBreaks
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinShipsInFormationDuringCombat
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxShipsInFormationDuringCombat
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single OutOfFormationMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutOfFormationMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcAISpaceshipModelData> RandomSpaceshipResources
	{
		get => cache.GetOrAddValue(new VirtualList<GcAISpaceshipModelData>(address + GetOffset()));
		set => TrySetValue<GcAISpaceshipModelData>(value);
	}

	public VirtualList<NMSString0x80> RandomPilotNPCResources
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcPlayerSquadronConfig(long address) : base(address)
	{

	}
}
