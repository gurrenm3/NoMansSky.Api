using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardScan : NMSTemplate
{
	public GcScanData ScanData
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcRewardScan(long address) : base(address)
	{

	}
}
