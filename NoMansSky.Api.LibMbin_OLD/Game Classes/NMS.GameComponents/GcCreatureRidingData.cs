using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRidingData : NMSTemplate
{
	public NMSString0x100 JointName
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 AdditionalScaleJoint
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Vector3f Offset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f RotationOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f VROffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single HeadCounterRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UprightStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LegSpread
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ScaleForNeutralLegSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleForMinLegSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleForMaxLegSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RequiresMatchingPartModifier
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCreatureRidingPartModifier> PartModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureRidingPartModifier>(address + GetOffset()));
		set => TrySetValue<GcCreatureRidingPartModifier>(value);
	}

	public NMSString0x10 IdleRidingAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultRidingAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcCreatureRidingAnimation> RidingAnims
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureRidingAnimation>(address + GetOffset()));
		set => TrySetValue<GcCreatureRidingAnimation>(value);
	}

	public GcCreatureRidingData(long address) : base(address)
	{

	}
}
