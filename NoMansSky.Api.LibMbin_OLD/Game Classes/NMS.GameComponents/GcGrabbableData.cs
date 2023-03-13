using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGrabbableData : NMSTemplate
{
	public NMSString0x20 LocatorName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single GrabRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttachTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ReleaseRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DetachTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcHand Hand
	{
		get => GetValue<GcHand>();
		set => TrySetValue<GcHand>(value);
	}

	public Vector2f RotationLimits
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Boolean AllowOtherWayUp
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoGrab
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ToggleGrabTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcGrabbableData.GrabTypeEnum GrabType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGrabbableData.GrabTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGrabbableData.GrabTypeEnum>(value);
	}

	public NMSString0x10 HandPose
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20 MovementStartLocator
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 MovementEndLocator
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single MovementMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MovementReturnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MovementRequiredForActivation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGrabbableData(long address) : base(address)
	{

	}
}
