using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyMarkerTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcGalaxyMarkerTypes.GalaxyMarkerTypeEnum GalaxyMarkerType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGalaxyMarkerTypes.GalaxyMarkerTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGalaxyMarkerTypes.GalaxyMarkerTypeEnum>(value);
	}

	public GcGalaxyMarkerTypes(long address) : base(address)
	{

	}
}
