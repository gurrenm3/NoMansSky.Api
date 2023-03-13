using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExperienceDebugTriggerAction : NMSTemplate
{
	public GcExperienceDebugTriggerActionTypes Action
	{
		get => GetValue<GcExperienceDebugTriggerActionTypes>();
		set => TrySetValue<GcExperienceDebugTriggerActionTypes>(value);
	}

	public Int32 IntParameter
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcExperienceDebugTriggerAction(long address) : base(address)
	{

	}
}
