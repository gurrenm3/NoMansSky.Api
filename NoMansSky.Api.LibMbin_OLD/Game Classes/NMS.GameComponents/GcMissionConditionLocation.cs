using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionLocation : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionLocation.MissionPlayerLocationEnum MissionPlayerLocation
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionLocation.MissionPlayerLocationEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionLocation.MissionPlayerLocationEnum>(value);
	}

	public GcMissionConditionLocation(long address) : base(address)
	{

	}
}
