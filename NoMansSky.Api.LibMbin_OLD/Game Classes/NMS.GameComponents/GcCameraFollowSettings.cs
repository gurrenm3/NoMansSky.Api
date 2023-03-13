using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraFollowSettings : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYSlopeExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetZFlat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BackMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BackMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BackSlopeAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BackSlopeRotationAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpSlopeAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeftMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeftMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetYExtraMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PanNear
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PanFar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpGamma
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizRotationAngleMaxPerFrame
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertRotationSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertRotationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertRotationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertRotationOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertRotationOffsetMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertRotationOffsetMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean VertStartLookingDown
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DistSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistSpeedOutsideMainRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistStiffness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpringSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LockToObjectOnIdle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CenterStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CenterBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CenterMaxSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CenterMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VelocityAnticipate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VelocityAnticipateSpringSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertMaxSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CenterStartSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinClose
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxClose
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloseSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookStickLimitAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableCollisionDetection
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumLRProbes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single LRProbesRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LRProbesRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumUDProbes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single UDProbesRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProbeCenterX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProbeCenterY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PushForwardDropoffLR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PushForwardDropoffUD
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidCollisionLRSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidCollisionUDSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidCollisionPushSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AvoidCollisionUDUseStickDelay
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AvoidCollisionLRUseStickDelay
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseSpeedBasedSpring
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseCustomBlendTime
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CustomBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraFollowSettings(long address) : base(address)
	{

	}
}
