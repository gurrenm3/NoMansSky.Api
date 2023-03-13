using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCInteractiveObjectType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCInteractiveObjectType.NPCInteractiveObjectTypeEnum NPCInteractiveObjectType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCInteractiveObjectType.NPCInteractiveObjectTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCInteractiveObjectType.NPCInteractiveObjectTypeEnum>(value);
	}

	public GcNPCInteractiveObjectType(long address) : base(address)
	{

	}
}
