using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEventTableType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScanEventTableType.ScanTableEnum ScanTable
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventTableType.ScanTableEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventTableType.ScanTableEnum>(value);
	}

	public GcScanEventTableType(long address) : base(address)
	{

	}
}
