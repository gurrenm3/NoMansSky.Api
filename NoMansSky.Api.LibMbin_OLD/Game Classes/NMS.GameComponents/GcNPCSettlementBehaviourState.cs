using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourState : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum NPCSettlementBehaviourState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum>(value);
	}

	public GcNPCSettlementBehaviourState(long address) : base(address)
	{

	}
}
