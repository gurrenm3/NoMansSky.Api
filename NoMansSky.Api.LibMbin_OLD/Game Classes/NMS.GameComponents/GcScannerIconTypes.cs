using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScannerIconTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScannerIconTypes.ScanIconTypeEnum ScanIconType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScannerIconTypes.ScanIconTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScannerIconTypes.ScanIconTypeEnum>(value);
	}

	public GcScannerIconTypes(long address) : base(address)
	{

	}
}
