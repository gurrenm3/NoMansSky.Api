using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeightingCurve : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWeightingCurve.WeightingCurveEnum WeightingCurve
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWeightingCurve.WeightingCurveEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWeightingCurve.WeightingCurveEnum>(value);
	}

	public GcWeightingCurve(long address) : base(address)
	{

	}
}
