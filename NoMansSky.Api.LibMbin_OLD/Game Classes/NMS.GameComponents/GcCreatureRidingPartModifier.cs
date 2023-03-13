using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRidingPartModifier : NMSTemplate
{
	public NMSString0x20A PartName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x100 JointName
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single MinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x100 AdditionalScaleJoint
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Boolean BreakIfNotSelected
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RelativeOffset
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
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

	public Single LegSpreadOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean OverrideAnims
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
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

	public GcCreatureRidingPartModifier(long address) : base(address)
	{

	}
}
