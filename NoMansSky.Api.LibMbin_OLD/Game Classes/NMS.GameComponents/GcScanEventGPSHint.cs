using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEventGPSHint : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScanEventGPSHint.ScanEventGPSHintEnum ScanEventGPSHint
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventGPSHint.ScanEventGPSHintEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventGPSHint.ScanEventGPSHintEnum>(value);
	}

	public GcScanEventGPSHint(long address) : base(address)
	{

	}
}
