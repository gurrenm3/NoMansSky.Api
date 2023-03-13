using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 NumWheels
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single WheelRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardExtraRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardExtraHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardAdjustUpwards
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterEnginePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterEngineMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterEngineFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterEngineDirectionBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterEngineDirectionBrakeVertical
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterAlignDir
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterAlignUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VisualRollAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VisualRollOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringWheelSpringMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringWheelPushRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Vector3f> WheelLocs
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector3f>(address + GetOffset(), 10));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualArray<NMSString0x20> WheelNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20>(address + GetOffset(), 10));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualArray<NMSString0x20> WheelSuspensionNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20>(address + GetOffset(), 10));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualArray<Single> WheelRayFakeWidthFactor
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 10));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> WheelRadiusMultiplier
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 10));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x10> SuspensionAnimNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 10));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean CustomCollision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f CollOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f ExtraCollOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f CollDimensions
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InertiaDimensions
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single CollRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InertiaMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSuspensionlength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSuspensionForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSuspensionDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSuspensionAnimMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSuspensionAnimMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TopSpeedForward
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TopSpeedReverse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelMaxAccelForceForward
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelMaxAccelForceReverse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelMaxDecelForceNonBraking
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelMaxDecelForceBraking
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSpinniness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelDragginess
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardStopSpeedThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelFrontFrictionOmega
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelFrontFrictionDynamic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelFrontFrictionDynamicThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelFrontFrictionStatic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelFrontFrictionStaticThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSideFrictionOmega
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSideFrictionDynamic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSideFrictionDynamicThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSideFrictionStatic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSideFrictionStaticThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LockVehicleAxis
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TurningWheelForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurningWheelForceDamperVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurningWheelFrictionOmega
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurningWheelFrictionNonBraking
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurningWheelFrictionBraking
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f WheelForwardAngularFactor
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WheelTurnAngularFactor
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WheelSuspensionAngularFactor
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WheelSideAngularFactor
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single VehicleGravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleGravityWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpAirControlForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostExtraMaxSpeedAir
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostSpeedFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostRechargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpAirRotateXAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpAirRotateZAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpAirRotateTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpAirRotateTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpAirMaxTorque
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseBuggySuspensionHack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseRoverWheelHack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 SideSkidParticle
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single SideSkidParticleMinRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SideSkidParticleMaxRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SideSkidParticleMinThresh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SideSkidParticleMaxThresh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 WheelSpinParticle
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single WheelSpinParticleMinRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSpinParticleMaxRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSpinParticleMinThresh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSpinParticleMaxThresh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardVerticalResponseMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardVerticalResponseMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardPenetrationScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardPenetrationScaleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardPenetrationScaleMinClamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardMassScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardMassScaleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGuardMassScaleMinClamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleLinearDampingGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAngularDampingGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleLinearDampingAerial
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAngularDampingAerial
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleLinearDampingWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAngularDampingWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelStartHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelEndHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleComCheat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioSpeedMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioTorqueMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioSideSkidMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioSideSkidThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioSpinSkidMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioSpinSkidThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AudioImpactSpeedThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AudioImpactSpeedMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean VehicleAudioSwapSkidAndSpeed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 AudioBoostStart
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioBoostStop
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioHornStart
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioHornStop
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioIdleExterior
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioImpacts
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioStart
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioStop
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioSuspension
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AudioJump
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean DriveOnTopOfWater
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single VehicleUnderwaterRotateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioSuspensionThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAudioSuspensionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumGrassPushers
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single WheelGrassPusherStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGrassPusherWobble
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGrassPusherFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelGrassPusherReduce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Vector3f> WheelGrassPushers
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector3f>(address + GetOffset(), 10));
		set => TrySetValue<Vector3f>(value);
	}

	public Single CreatureMassScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x100> HeadlightNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x100>(address + GetOffset(), 2));
		set => TrySetValue<NMSString0x100>(value);
	}

	public VirtualArray<NMSString0x100> VolumetricHeadlightNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x100>(address + GetOffset(), 2));
		set => TrySetValue<NMSString0x100>(value);
	}

	public VirtualArray<NMSString0x100> CockpitHeadlightNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x100>(address + GetOffset(), 2));
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single HeadlightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcVehicleData(long address) : base(address)
	{

	}
}
