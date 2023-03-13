using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionNearObject : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionNearObject.MissionObjectEnum MissionObject
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionNearObject.MissionObjectEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionNearObject.MissionObjectEnum>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionConditionNearObject(long address) : base(address)
	{

	}
}
