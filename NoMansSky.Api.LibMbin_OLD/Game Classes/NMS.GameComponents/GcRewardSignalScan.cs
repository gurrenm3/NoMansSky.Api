using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSignalScan : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardSignalScan.SignalScanTypeEnum SignalScanType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardSignalScan.SignalScanTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardSignalScan.SignalScanTypeEnum>(value);
	}

	public GcRewardSignalScan(long address) : base(address)
	{

	}
}
