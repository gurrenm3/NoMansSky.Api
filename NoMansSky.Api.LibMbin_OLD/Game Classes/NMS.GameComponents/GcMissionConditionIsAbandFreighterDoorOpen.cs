using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsAbandFreighterDoorOpen : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionIsAbandFreighterDoorOpen.AbandonedFreighterDoorStatusEnum AbandonedFreighterDoorStatus
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionIsAbandFreighterDoorOpen.AbandonedFreighterDoorStatusEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionIsAbandFreighterDoorOpen.AbandonedFreighterDoorStatusEnum>(value);
	}

	public GcMissionConditionIsAbandFreighterDoorOpen(long address) : base(address)
	{

	}
}
