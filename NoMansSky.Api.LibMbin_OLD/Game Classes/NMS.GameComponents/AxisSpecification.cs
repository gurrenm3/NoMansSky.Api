using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class AxisSpecification : NMSTemplate
{
	public libMBIN.NMS.GameComponents.AxisSpecification.AxisEnum Axis
	{
		get => GetValue<libMBIN.NMS.GameComponents.AxisSpecification.AxisEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.AxisSpecification.AxisEnum>(value);
	}

	public Vector3f CustomAxis
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public AxisSpecification(long address) : base(address)
	{

	}
}
