using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCTriggerTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCTriggerTypes.NPCTriggerEnum NPCTrigger
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCTriggerTypes.NPCTriggerEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCTriggerTypes.NPCTriggerEnum>(value);
	}

	public GcNPCTriggerTypes(long address) : base(address)
	{

	}
}
