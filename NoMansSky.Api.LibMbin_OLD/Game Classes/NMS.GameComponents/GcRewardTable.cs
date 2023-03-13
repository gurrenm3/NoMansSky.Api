using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTable : NMSTemplate
{
	public VirtualList<GcGenericRewardTableEntry> GenericTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> DestructionTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> InteractionTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> OldInteractionTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SpecialRewardTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> MissionBoardTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> FleetTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> WikiProgressTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> ShipSalvageTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcRewardTableEntitlementItem> EntitlementTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcRewardTableEntitlementItem>(address + GetOffset()));
		set => TrySetValue<GcRewardTableEntitlementItem>(value);
	}

	public VirtualList<GcRewardTableEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcRewardTableEntry>(value);
	}

	public VirtualList<NMSString0x10> TechRewardOrder
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> ProductRewardOrder
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> MixerRewardTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> TwitchRewardTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> NPCPlanetSiteTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SettlementTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable1
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable2
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable3
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable4
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable5
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable6
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable7
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable8
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable9
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable10
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> SeasonRewardTable11
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public GcRewardTable(long address) : base(address)
	{

	}
}
