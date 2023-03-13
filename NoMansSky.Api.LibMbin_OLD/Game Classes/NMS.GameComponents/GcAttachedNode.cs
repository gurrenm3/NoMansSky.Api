using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAttachedNode : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x40 NodeName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Single MinRenderIFraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRenderJFraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRenderIFraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRenderJFraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlendStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f RelativeTransform_Axis0
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f RelativeTransform_Axis1
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f RelativeTransform_Axis2
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f RelativeTransform_Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcAttachedNode(long address) : base(address)
	{

	}
}
