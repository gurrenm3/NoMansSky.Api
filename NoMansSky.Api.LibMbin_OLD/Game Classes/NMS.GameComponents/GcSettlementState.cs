using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementState : NMSTemplate
{
	public NMSString0x40 UniqueId
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public UInt64 UniverseAddress
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public UInt64 SeedValue
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualArray<Int32> BuildingStates
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 48));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<UInt64> LastBuildingUpgradesTimestamps
	{
		get => cache.GetOrAddValue(new VirtualArray<UInt64>(address + GetOffset(), 48));
		set => TrySetValue<UInt64>(value);
	}

	public NMSString0x40 Name
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcDiscoveryOwner Owner
	{
		get => GetValue<GcDiscoveryOwner>();
		set => TrySetValue<GcDiscoveryOwner>(value);
	}

	public GcSettlementJudgementType PendingJudgementType
	{
		get => GetValue<GcSettlementJudgementType>();
		set => TrySetValue<GcSettlementJudgementType>(value);
	}

	public NMSString0x10 PendingCustomJudgementID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<Int32> Stats
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x10> Perks
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public UInt64 LastJudgementTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 LastUpkeepDebtCheckTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 LastDebtChangeTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 LastAlertChangeTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public NMSString0x40 DbResourceId
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public UInt64 DbTimestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 DbVersion
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<GcSettlementProductionSlotData> ProductionState
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSettlementProductionSlotData>(address + GetOffset(), 2));
		set => TrySetValue<GcSettlementProductionSlotData>(value);
	}

	public Boolean IsReported
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NextBuildingUpgradeIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBuildingClassification NextBuildingUpgradeClass
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public UInt64 NextBuildingUpgradeSeedValue
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcSettlementState(long address) : base(address)
	{

	}
}
