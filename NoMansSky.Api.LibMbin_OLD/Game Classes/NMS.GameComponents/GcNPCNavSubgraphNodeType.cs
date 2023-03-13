using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCNavSubgraphNodeType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCNavSubgraphNodeType.NPCNavSubgraphNodeTypeEnum NPCNavSubgraphNodeType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCNavSubgraphNodeType.NPCNavSubgraphNodeTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCNavSubgraphNodeType.NPCNavSubgraphNodeTypeEnum>(value);
	}

	public GcNPCNavSubgraphNodeType(long address) : base(address)
	{

	}
}
