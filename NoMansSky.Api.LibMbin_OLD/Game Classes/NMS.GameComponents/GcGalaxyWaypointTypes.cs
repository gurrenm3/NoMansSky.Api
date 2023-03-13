using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyWaypointTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcGalaxyWaypointTypes.GalaxyWaypointTypeEnum GalaxyWaypointType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGalaxyWaypointTypes.GalaxyWaypointTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGalaxyWaypointTypes.GalaxyWaypointTypeEnum>(value);
	}

	public GcGalaxyWaypointTypes(long address) : base(address)
	{

	}
}
