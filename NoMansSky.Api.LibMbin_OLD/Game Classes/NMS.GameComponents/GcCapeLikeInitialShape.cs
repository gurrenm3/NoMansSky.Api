using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCapeLikeInitialShape : NMSTemplate
{
	public Single TopRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TopInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BottomRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TopDropOffHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ForwardSquash
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f Top
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

	public Single CircleStartAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CircleEndAngle
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

	public Int32 NumFixedTopRowsInInitialShape
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumExtraFixedBoundaryRowsInInitialShape
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCapeLikeInitialShape(long address) : base(address)
	{

	}
}
