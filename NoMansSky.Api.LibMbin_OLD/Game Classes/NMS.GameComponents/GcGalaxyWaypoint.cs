using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyWaypoint : NMSTemplate
{
	public GcGalacticAddressData Address
	{
		get => GetValue<GcGalacticAddressData>();
		set => TrySetValue<GcGalacticAddressData>(value);
	}

	public GcGalaxyWaypointTypes Type
	{
		get => GetValue<GcGalaxyWaypointTypes>();
		set => TrySetValue<GcGalaxyWaypointTypes>(value);
	}

	public NMSString0x20A EventId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcGalaxyWaypoint(long address) : base(address)
	{

	}
}
