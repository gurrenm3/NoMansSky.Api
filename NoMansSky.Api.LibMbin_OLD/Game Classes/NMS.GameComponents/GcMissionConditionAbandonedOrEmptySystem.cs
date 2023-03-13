using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionAbandonedOrEmptySystem : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionAbandonedOrEmptySystem.MissionSystemTypeEnum MissionSystemType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionAbandonedOrEmptySystem.MissionSystemTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionAbandonedOrEmptySystem.MissionSystemTypeEnum>(value);
	}

	public GcMissionConditionAbandonedOrEmptySystem(long address) : base(address)
	{

	}
}
