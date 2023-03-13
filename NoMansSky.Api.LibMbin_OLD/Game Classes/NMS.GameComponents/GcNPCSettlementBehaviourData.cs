using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourData : NMSTemplate
{
	public GcNPCSettlementBehaviourEntry BaseBehaviour
	{
		get => GetValue<GcNPCSettlementBehaviourEntry>();
		set => TrySetValue<GcNPCSettlementBehaviourEntry>(value);
	}

	public VirtualArray<GcNPCSettlementBehaviourEntry> BehaviourOverrides
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNPCSettlementBehaviourEntry>(address + GetOffset(), 5));
		set => TrySetValue<GcNPCSettlementBehaviourEntry>(value);
	}

	public GcNPCSettlementBehaviourData(long address) : base(address)
	{

	}
}
