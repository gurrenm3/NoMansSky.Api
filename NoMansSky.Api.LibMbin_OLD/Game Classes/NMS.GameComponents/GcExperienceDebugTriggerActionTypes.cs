using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExperienceDebugTriggerActionTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcExperienceDebugTriggerActionTypes.ExperienceDebugTriggerActionEnum ExperienceDebugTriggerAction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcExperienceDebugTriggerActionTypes.ExperienceDebugTriggerActionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcExperienceDebugTriggerActionTypes.ExperienceDebugTriggerActionEnum>(value);
	}

	public GcExperienceDebugTriggerActionTypes(long address) : base(address)
	{

	}
}
