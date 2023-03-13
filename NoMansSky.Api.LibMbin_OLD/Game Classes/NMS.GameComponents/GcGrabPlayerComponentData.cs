using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGrabPlayerComponentData : NMSTemplate
{
	public NMSString0x100 LookJoint
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 GrabJoint
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x10 DefendAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 IdleAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 GrabAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 HoldAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 HitReactAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 PlayerGrabbedAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DamageType
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single DamageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TriggerRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAudioWwiseEvents GrabBeginAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents GrabEndAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single LungeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrabRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrabAttachStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrabBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EjectImpulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f GrabOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single HoldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CooldownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxLookAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BodgeInputAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BodgeOutputAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitReactAnimChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HitReactAngles
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ActivateRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FocusRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f LookAroundTrackTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single LookAroundFineModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f LookAtPlayerTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single LookAtPlayerChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f LookAroundTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f LookAroundAngles
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f LookAroundAnglesFine
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single SleepChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f SleepTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcGrabPlayerComponentData(long address) : base(address)
	{

	}
}
