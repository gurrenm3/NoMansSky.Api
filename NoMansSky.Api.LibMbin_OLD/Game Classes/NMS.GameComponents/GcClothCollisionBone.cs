using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcClothCollisionBone : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x40 DebugName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x40 BoneName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Vector3f CapsuleCentre
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public AxisSpecification CapsuleAxis
	{
		get => GetValue<AxisSpecification>();
		set => TrySetValue<AxisSpecification>(value);
	}

	public Single CapsuleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CapsuleLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ImproveCollisionForNarrowCapsule
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcClothCollisionBone(long address) : base(address)
	{

	}
}
