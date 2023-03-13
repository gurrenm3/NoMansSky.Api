using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRobotGlobals : NMSTemplate
{
	public Boolean ForceShowDebugMoveTrail
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 ForceDroneWeapon
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single GrenadeLaunchFlightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 AttackSentinelWantedValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxNumPatrolDrones
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single UnderwaterPerceptionMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DronePatrolScanPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DroneSearchPickNearbyTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchPickNearbyAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchPickNearbyAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateMinWitnessRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateMinWitnessRangeCantSee
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateMinChaseRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateMinWitnessTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateSpeedBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateSpeedBoostStartDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateSpeedBoostRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneCrimePostInvestigateWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EncounterRangeToBlockWantedSpawns
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EncounterRangeToAllowPulledIntoFight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DroneEnableVariableUpdate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DroneUpdateFPSMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneUpdateFPSMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneUpdateDistForMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneUpdateDistForMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneAttackPlayerHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneAttackMaxAngleDownFromPlayer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSpawnFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineOfSightReturnCheckMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineOfSightReturnCheckRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineOfSightReturnRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FakeQuadGuard
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RobotSightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneChatCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneDissolveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneChatChanceSummoned
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneChatChanceUnsummoned
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneChatChanceBecomeWanted
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneChatChanceLoseWanted
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneChatChanceIdle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FriendlyDroneBeepReplaceChatChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f DroneRepairOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single QuadLookAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadLookAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f QuadLookTurnSpeeds
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single QuadAttackTurnAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadAttackTurnAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f QuadAttackTurnSpeeds
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 DroneAggroDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CombatWaveSpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePerceptionMinHearingSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchLookSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSearchLookDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneCrimeWitnessInvestigateDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DroneChatter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WalkerEnergyLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerEnergySpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerEnergySpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerEnergyRadiusStartMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerEnergyRadiusStartMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerEnergyMinAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerEnergyMaxAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalHitSizeDrone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalHitSizeQuad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalHitSizeMech
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalHitSizeWalker
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LabelOffsetDrone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LabelOffsetQuad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LabelOffsetMech
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LabelOffsetWalker
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f QuadCriticalOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DroneCriticalOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WalkerGunOffset1
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WalkerGunOffset2
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single RobotSteeringFollowWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RobotSteeringAvoidTurnWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RobotSteeringAvoidCreaturesWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RobotSteeringAvoidDangerWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanData AttackScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public Single RobotHUDMarkerRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RobotHUDMarkerFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneMoveDistancePlayerMechMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSquadSpawnRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneSpawnHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackArrowOffsetMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneCombatSpawnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatSpawnSquadRadiusDrones
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatSpawnSquadRadiusRobots
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RobotMapScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerLaserOvershootVehicleReducer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DronesUseEscalationTimer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableDronePerception
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DroneHeightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneAttackGetInRangeBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneAggressiveInvestigateAttackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePushLaserForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePushMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePushMaxTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneCriminalScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DroneClickToMove
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DroneInvestigateMinScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MedicDroneMinHealTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData DroneScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public VirtualArray<Int32> SentinelSpawnLimits
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 9));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<GcSentinelResource> SentinelResources
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSentinelResource>(address + GetOffset(), 9));
		set => TrySetValue<GcSentinelResource>(value);
	}

	public Single HeightTestSampleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightTestSampleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RobotSightTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DroneHitImpulseEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DroneHitImpulseFlipForceDownBound
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneHitImpulseMinVerticalComponentScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneHitImpulseMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneHitImpulseLaserMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneHitImpulseCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneReAttackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolAttackSightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolInvestigateSpeedBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolSearchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNumInvestigatingDrones
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DroneCrimeCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneCrimeCooldownWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneCrimeCooldownWaitTimeAtMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneMaxScanLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneDecisionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateMinPositionAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateMaxPositionAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateRepositionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneInvestigateMinCrimeInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneScanRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneMaxScanAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneScanWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneScanMinPerpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyExplodeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowRoutineArriveRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairCheckForTargetCooldownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairOffsetChangeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairScanArriveDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairScanRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 RepairEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single RepairEffectScaleDrone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairEffectScaleQuad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFadeInDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExoMechJumpCooldownTimeInCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExoMechJumpCooldownTimeOutOfCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SentinelMechJumpCooldownTimeInCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SentinelMechJumpCooldownTimeOutOfCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechStartJumpMinDistanceInCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechEndJumpMinDistanceInCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechStartJumpMinDistanceOutOfCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechEndJumpMinDistanceOutOfCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMechTargetSelectionWeightingSettings MechTargetSelectionWeightingSettings
	{
		get => GetValue<GcMechTargetSelectionWeightingSettings>();
		set => TrySetValue<GcMechTargetSelectionWeightingSettings>(value);
	}

	public Single MechMinMaintainTargetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechMinMaintainFireTargetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAttackRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechMinTurretAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAttackMoveMinOffsetRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAttackMoveMaxOffsetRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAttackMoveHoldPositionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAttackMoveAngleToleranceDeg
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAttackMoveFacingAngleTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAlertRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAttackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechSightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechSightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechHearingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechPatrolRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f MechPatrolPauseTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualArray<GcSentinelMechWeaponData> SentinelMechWeaponData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSentinelMechWeaponData>(address + GetOffset(), 3));
		set => TrySetValue<GcSentinelMechWeaponData>(value);
	}

	public Single WalkerPauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerAttackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerGuardAlertRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerClosingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerAttackRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerAttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerFastMoveFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerNavRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerPushTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerPushRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerLaserOvershootStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerLaserOvershootEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerLaserBodyOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerObstacleSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerGunShootTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerGunChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerGunRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerTitanFallHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerTitanFallSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 WalkerTitanFallEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single WalkerTitanFallEffectScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 WalkerTitanFallShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x20> WalkerLeftLegArmourNodes
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x20> WalkerRightLegArmourNodes
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean WalkerLegShotDefendEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WalkerLegShotDefendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean WalkerLegShotEnrageEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WalkerLegShotEnrageShotInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 WalkerLegShotEnrageShotsPerVolley
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single WalkerLegShotEnrageVolleyInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerLegShotEnrageShotSpreadMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerLegShotEnrageShotSpreadMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerHeadMoveTimeIdle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerHeadMoveTimeActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerHeadMaxYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerHeadMaxPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f WalkerHeadEyeOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single QuadAlertRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadAttackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadAttackMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadAttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadAttackRepositionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackCheckRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackHeightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackJumpDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackJumpMinLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackDoFlipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackFacingAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackTestRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadJumpBackTestHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceMinTimeBetweenPounces
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceTimeFireRateScoreExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceMinFireRateScore
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceMaxFireRateScore
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPounceDamageRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadCannotSeeTargetRepositionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadFireTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadChargeTargetLockPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadHopMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadHopCombatMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 QuadDamageMoveThreshold
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single QuadAttackRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadLaserSpringMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadLaserSpringMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadLaserIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadFastMoveFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadTurnBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadNavRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadObstacleSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadPatrolRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f QuadPatrolPauseTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single QuadHearingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadSightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuadSightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePerceptionRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePerceptionRangeHostile
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePerceptionSightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePerceptionSightRangeHostile
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePerceptionSightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SpawnFriendlyDrone
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AttackMoveMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMoveArrivalDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserFadeTime2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SummonerDroneResummonThreshold
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SummonerDroneCooldownOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonerDroneCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonerDroneBeginTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonerDroneBuildupTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 SummonerDroneBuildupEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SummonerDroneSpawnEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single SummonRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonVerticalOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonPreviewInterpSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonPreviewInterpSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SummonerTestSummonEffects
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FireRateLastHitBypassTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FireRateModifierMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FireRateModifierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ScoreForMinFireRateModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ScoreForMaxFireRateModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Single> FireRateModifierScores
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 9));
		set => TrySetValue<Single>(value);
	}

	public GcRobotLaserData WalkerLaser
	{
		get => GetValue<GcRobotLaserData>();
		set => TrySetValue<GcRobotLaserData>(value);
	}

	public GcRobotLaserData QuadLaser
	{
		get => GetValue<GcRobotLaserData>();
		set => TrySetValue<GcRobotLaserData>(value);
	}

	public GcDroneData DroneControl
	{
		get => GetValue<GcDroneData>();
		set => TrySetValue<GcDroneData>(value);
	}

	public VirtualList<GcDroneWeaponData> DroneWeapons
	{
		get => cache.GetOrAddValue(new VirtualList<GcDroneWeaponData>(address + GetOffset()));
		set => TrySetValue<GcDroneWeaponData>(value);
	}

	public GcRobotGlobals(long address) : base(address)
	{

	}
}
