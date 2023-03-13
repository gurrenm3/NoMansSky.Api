using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureDebugWaypoint : NMSTemplate
{
	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureDebugWaypoint.WaypointTypeEnum WaypointType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureDebugWaypoint.WaypointTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureDebugWaypoint.WaypointTypeEnum>(value);
	}

	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureDebugWaypoint(long address) : base(address)
	{

	}
}
