using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkEmitterFloatProperty : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkEmitterFloatProperty.AuthoringEnum Authoring
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkEmitterFloatProperty.AuthoringEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkEmitterFloatProperty.AuthoringEnum>(value);
	}

	public Single FixedValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRandomValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRandomValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CurveVariation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CurveStartValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CurveMidValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CurveEndValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CurveBlendMidpoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType Curve1Shape
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType Curve2Shape
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public NMSTemplate NextStage
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public TkEmitterFloatProperty(long address) : base(address)
	{

	}
}
