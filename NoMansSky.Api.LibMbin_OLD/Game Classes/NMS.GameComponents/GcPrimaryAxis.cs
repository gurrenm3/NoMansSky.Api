using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPrimaryAxis : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPrimaryAxis.PrimaryAxisEnum PrimaryAxis
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPrimaryAxis.PrimaryAxisEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPrimaryAxis.PrimaryAxisEnum>(value);
	}

	public GcPrimaryAxis(long address) : base(address)
	{

	}
}
