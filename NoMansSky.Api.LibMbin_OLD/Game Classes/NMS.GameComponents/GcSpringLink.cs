using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpringLink : NMSTemplate
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

	public VirtualList<NMSString0x40> NodeNames
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x40>(address + GetOffset()));
		set => TrySetValue<NMSString0x40>(value);
	}

	public Vector3f SpringCentreLocal
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f SpringPivotLocal
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean PositionalSpringEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DampingCriticality
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NaturalFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SpringPivotsAsOpposedToParallelTransport
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ApplySpringInMovingFrame
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcSpringLink.ApplyMotionScaleInEnum ApplyMotionScaleIn
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyMotionScaleInEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyMotionScaleInEnum>(value);
	}

	public Single MotionScale_Uniform
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f MotionScale
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public libMBIN.NMS.GameComponents.GcSpringLink.ApplyMotionLimitsInEnum ApplyMotionLimitsIn
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyMotionLimitsInEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyMotionLimitsInEnum>(value);
	}

	public Vector3f MotionLimitMin
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f MotionLimitMax
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f MotionLimitBounciness
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean AngularSpringEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AngularDampingCriticality
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngularNaturalFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ApplyAngularSpringInMovingFrame
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcSpringLink.ApplyAngularMotionScaleInEnum ApplyAngularMotionScaleIn
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyAngularMotionScaleInEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyAngularMotionScaleInEnum>(value);
	}

	public Single AngularMotionScale_Uniform
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f AngularMotionScale
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public libMBIN.NMS.GameComponents.GcSpringLink.ApplyAngularLimitsInEnum ApplyAngularLimitsIn
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyAngularLimitsInEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpringLink.ApplyAngularLimitsInEnum>(value);
	}

	public Vector3f AngularLimitMinDeg
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f AngularLimitMaxDeg
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f AngularMotionLimitBounciness
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<NMSString0x40> NodesThatMustBePresent
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x40>(address + GetOffset()));
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcSpringLink(long address) : base(address)
	{

	}
}
