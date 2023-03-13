using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSizeIndicator : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSizeIndicator.SizeIndicatorEnum SizeIndicator
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSizeIndicator.SizeIndicatorEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSizeIndicator.SizeIndicatorEnum>(value);
	}

	public GcSizeIndicator(long address) : base(address)
	{

	}
}
