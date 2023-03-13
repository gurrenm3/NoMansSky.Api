using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipAIAttackDataTable : NMSTemplate
{
	public VirtualList<GcShipAICombatDefinition> Definitions
	{
		get => cache.GetOrAddValue(new VirtualList<GcShipAICombatDefinition>(address + GetOffset()));
		set => TrySetValue<GcShipAICombatDefinition>(value);
	}

	public VirtualList<GcShipAIAttackData> BehaviourTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcShipAIAttackData>(address + GetOffset()));
		set => TrySetValue<GcShipAIAttackData>(value);
	}

	public VirtualList<GcSpaceshipTravelData> EngineTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcSpaceshipTravelData>(address + GetOffset()));
		set => TrySetValue<GcSpaceshipTravelData>(value);
	}

	public VirtualList<GcSpaceshipShieldData> ShieldTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcSpaceshipShieldData>(address + GetOffset()));
		set => TrySetValue<GcSpaceshipShieldData>(value);
	}

	public VirtualArray<NMSString0x10> TraderAttackLookup
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcShipAIAttackDataTable(long address) : base(address)
	{

	}
}
