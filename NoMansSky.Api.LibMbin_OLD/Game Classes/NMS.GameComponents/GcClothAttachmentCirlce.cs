using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcClothAttachmentCirlce : NMSTemplate
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

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f Center
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public AxisSpecification RightAxis
	{
		get => GetValue<AxisSpecification>();
		set => TrySetValue<AxisSpecification>(value);
	}

	public AxisSpecification ForwardAxis
	{
		get => GetValue<AxisSpecification>();
		set => TrySetValue<AxisSpecification>(value);
	}

	public AxisSpecification ClothDirection
	{
		get => GetValue<AxisSpecification>();
		set => TrySetValue<AxisSpecification>(value);
	}

	public Single StartAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EndAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean WrapIAround
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean WrapJAround
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumRowsOfSameJToFix
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RowToFixJ
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AttractionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractionStartDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartIFraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EndIFraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JStepDistanceOverride
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcClothAttachmentCirlce(long address) : base(address)
	{

	}
}
