using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCPropType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCPropType.NPCPropEnum NPCProp
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCPropType.NPCPropEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCPropType.NPCPropEnum>(value);
	}

	public GcNPCPropType(long address) : base(address)
	{

	}
}
