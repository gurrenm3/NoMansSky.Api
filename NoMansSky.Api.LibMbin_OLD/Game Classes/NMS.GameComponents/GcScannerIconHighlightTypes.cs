using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScannerIconHighlightTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum ScannerIconHighlightType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum>(value);
	}

	public GcScannerIconHighlightTypes(long address) : base(address)
	{

	}
}
