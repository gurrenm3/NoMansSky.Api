using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScannerBuildingIconTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum ScanBuildingIconType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum>(value);
	}

	public GcScannerBuildingIconTypes(long address) : base(address)
	{

	}
}
