using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSettlementBehaviourObjectTypeWeightEntry : NMSTemplate
{
	public GcNPCInteractiveObjectType ObjectType
	{
		get => GetValue<GcNPCInteractiveObjectType>();
		set => TrySetValue<GcNPCInteractiveObjectType>(value);
	}

	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcNPCSettlementBehaviourObjectTypeWeightEntry(long address) : base(address)
	{

	}
}
