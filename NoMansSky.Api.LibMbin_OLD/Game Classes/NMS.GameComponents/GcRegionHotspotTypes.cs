using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRegionHotspotTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRegionHotspotTypes.HotspotTypeEnum HotspotType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRegionHotspotTypes.HotspotTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRegionHotspotTypes.HotspotTypeEnum>(value);
	}

	public GcRegionHotspotTypes(long address) : base(address)
	{

	}
}
