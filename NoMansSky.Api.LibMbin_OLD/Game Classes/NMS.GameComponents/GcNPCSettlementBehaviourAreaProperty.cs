using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourAreaProperty : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCSettlementBehaviourAreaProperty.NPCSettlementBehaviourAreaPropertyEnum NPCSettlementBehaviourAreaProperty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCSettlementBehaviourAreaProperty.NPCSettlementBehaviourAreaPropertyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCSettlementBehaviourAreaProperty.NPCSettlementBehaviourAreaPropertyEnum>(value);
	}

	public GcNPCSettlementBehaviourAreaProperty(long address) : base(address)
	{

	}
}
