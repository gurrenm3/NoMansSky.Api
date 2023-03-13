using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourAreaPropertyWeightEntry : NMSTemplate
{
	public GcNPCSettlementBehaviourAreaProperty AreaProperty
	{
		get => GetValue<GcNPCSettlementBehaviourAreaProperty>();
		set => TrySetValue<GcNPCSettlementBehaviourAreaProperty>(value);
	}

	public Single EntryWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcNPCSettlementBehaviourAreaPropertyWeightEntry(long address) : base(address)
	{

	}
}
