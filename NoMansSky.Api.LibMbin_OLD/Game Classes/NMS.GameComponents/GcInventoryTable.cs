using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryTable : NMSTemplate
{
	public VirtualList<GcInventoryTableEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryTableEntry>(address + GetOffset()));
		set => TrySetValue<GcInventoryTableEntry>(value);
	}

	public GcInventoryLayoutGenerationData GenerationData
	{
		get => GetValue<GcInventoryLayoutGenerationData>();
		set => TrySetValue<GcInventoryLayoutGenerationData>(value);
	}

	public GcInventoryCostData ShipCostData
	{
		get => GetValue<GcInventoryCostData>();
		set => TrySetValue<GcInventoryCostData>(value);
	}

	public VirtualArray<GcInventoryCostDataEntry> WeaponCostData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInventoryCostDataEntry>(address + GetOffset(), 5));
		set => TrySetValue<GcInventoryCostDataEntry>(value);
	}

	public GcInventoryCostDataEntry VehicleCostData
	{
		get => GetValue<GcInventoryCostDataEntry>();
		set => TrySetValue<GcInventoryCostDataEntry>(value);
	}

	public VirtualArray<GcInventoryClassProbabilities> ClassProbabilityData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInventoryClassProbabilities>(address + GetOffset(), 4));
		set => TrySetValue<GcInventoryClassProbabilities>(value);
	}

	public GcInventoryGenerationBaseStatData VehicleBaseStatsData
	{
		get => GetValue<GcInventoryGenerationBaseStatData>();
		set => TrySetValue<GcInventoryGenerationBaseStatData>(value);
	}

	public VirtualArray<GcInventoryGenerationBaseStatData> ShipBaseStatsData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInventoryGenerationBaseStatData>(address + GetOffset(), 9));
		set => TrySetValue<GcInventoryGenerationBaseStatData>(value);
	}

	public VirtualArray<GcInventoryGenerationBaseStatData> WeaponBaseStatsData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInventoryGenerationBaseStatData>(address + GetOffset(), 5));
		set => TrySetValue<GcInventoryGenerationBaseStatData>(value);
	}

	public VirtualList<GcInventoryBaseStat> BaseStats
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryBaseStat>(address + GetOffset()));
		set => TrySetValue<GcInventoryBaseStat>(value);
	}

	public VirtualArray<GcShipInventoryMaxUpgradeCapacity> ShipInventoryMaxUpgradeSize
	{
		get => cache.GetOrAddValue(new VirtualArray<GcShipInventoryMaxUpgradeCapacity>(address + GetOffset(), 9));
		set => TrySetValue<GcShipInventoryMaxUpgradeCapacity>(value);
	}

	public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize
	{
		get => GetValue<GcWeaponInventoryMaxUpgradeCapacity>();
		set => TrySetValue<GcWeaponInventoryMaxUpgradeCapacity>(value);
	}

	public GcInventoryTable(long address) : base(address)
	{

	}
}
