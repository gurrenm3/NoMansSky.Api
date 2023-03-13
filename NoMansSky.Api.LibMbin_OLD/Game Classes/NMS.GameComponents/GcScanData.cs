using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScanData.ScanTypeEnum ScanType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanData.ScanTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanData.ScanTypeEnum>(value);
	}

	public Single PulseRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PlayAudioOnMarkers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanData(long address) : base(address)
	{

	}
}
