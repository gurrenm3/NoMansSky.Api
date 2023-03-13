using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExperienceDebugTriggerInput : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcExperienceDebugTriggerInput.KeyPressEnum KeyPress
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcExperienceDebugTriggerInput.KeyPressEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcExperienceDebugTriggerInput.KeyPressEnum>(value);
	}

	public VirtualList<GcExperienceDebugTriggerAction> Actions
	{
		get => cache.GetOrAddValue(new VirtualList<GcExperienceDebugTriggerAction>(address + GetOffset()));
		set => TrySetValue<GcExperienceDebugTriggerAction>(value);
	}

	public GcExperienceDebugTriggerInput(long address) : base(address)
	{

	}
}
