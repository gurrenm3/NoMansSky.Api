using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardScanEvent : NMSTemplate
{
	public NMSString0x20A Event
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcRewardScanEvent.ScanEventTableEnum ScanEventTable
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardScanEvent.ScanEventTableEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardScanEvent.ScanEventTableEnum>(value);
	}

	public Boolean DoAerialScan
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseMissionSeedForEvent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single StartDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseStartDelayWhenNoAerialScan
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardScanEvent(long address) : base(address)
	{

	}
}
