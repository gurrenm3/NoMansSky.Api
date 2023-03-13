using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyConfig : NMSTemplate
{
	public NMSString0x20A PresetLocId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> PresetOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<GcDifficultySettingsData> Presets
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDifficultySettingsData>(address + GetOffset(), 7));
		set => TrySetValue<GcDifficultySettingsData>(value);
	}

	public GcDifficultySettingsData PermadeathMinSettings
	{
		get => GetValue<GcDifficultySettingsData>();
		set => TrySetValue<GcDifficultySettingsData>(value);
	}

	public VirtualArray<GcDifficultyOptionUIGroup> UILayout
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDifficultyOptionUIGroup>(address + GetOffset(), 4));
		set => TrySetValue<GcDifficultyOptionUIGroup>(value);
	}

	public VirtualArray<GcDifficultySettingCommonData> CommonSettingsData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDifficultySettingCommonData>(address + GetOffset(), 28));
		set => TrySetValue<GcDifficultySettingCommonData>(value);
	}

	public Int32 AllSlotsUnlockedStartingSuitSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AllSlotsUnlockedStartingSuitTechSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AllSlotsUnlockedStartingWeaponSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AllSlotsUnlockedStartingShipSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AllSlotsUnlockedStartingShipTechSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownDisabledData
	{
		get => GetValue<GcDifficultyStartWithAllItemsKnownOptionData>();
		set => TrySetValue<GcDifficultyStartWithAllItemsKnownOptionData>(value);
	}

	public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownEnabledData
	{
		get => GetValue<GcDifficultyStartWithAllItemsKnownOptionData>();
		set => TrySetValue<GcDifficultyStartWithAllItemsKnownOptionData>(value);
	}

	public VirtualArray<NMSString0x20A> CreatureHostilityOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> DeathConsequencesOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> DamageReceivedOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> DamageReceivedMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> DamageGivenOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> DamageGivenMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> ActiveSurvivalBarsOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> HazardDrainOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> HazardDrainMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> EnergyDrainOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> EnergyDrainMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> SubstanceCollectionOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> SubstanceCollectionMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> SubstanceCollectionLaserAmount
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<NMSString0x20A> InventoryStackLimitsOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<GcDifficultyInventoryStackSizeOptionData> InventoryStackLimitsOptionData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDifficultyInventoryStackSizeOptionData>(address + GetOffset(), 3));
		set => TrySetValue<GcDifficultyInventoryStackSizeOptionData>(value);
	}

	public VirtualArray<NMSString0x20A> ChargingRequirementsOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> ChargingRequirementsMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> FuelUseOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<GcDifficultyFuelUseOptionData> FuelUseOptionData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDifficultyFuelUseOptionData>(address + GetOffset(), 4));
		set => TrySetValue<GcDifficultyFuelUseOptionData>(value);
	}

	public VirtualArray<NMSString0x20A> LaunchFuelCostOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> LaunchFuelCostMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> ShipSummoningFuelCostMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> CurrencyCostOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<GcDifficultyCurrencyCostOptionData> CurrencyCostOptionData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDifficultyCurrencyCostOptionData>(address + GetOffset(), 4));
		set => TrySetValue<GcDifficultyCurrencyCostOptionData>(value);
	}

	public VirtualArray<NMSString0x20A> ItemShopAvailabilityOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<GcItemShopAvailabilityDifficultyOptionData> ItemShopAvailabilityOptionData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcItemShopAvailabilityDifficultyOptionData>(address + GetOffset(), 3));
		set => TrySetValue<GcItemShopAvailabilityDifficultyOptionData>(value);
	}

	public VirtualArray<NMSString0x20A> ScannerRechargeOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> ScannerRechargeMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> ReputationGainOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> ReputationGainMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> SpaceCombatOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> SpaceCombatMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> SpaceCombatDifficultyMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> GroundCombatOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> GroundCombatMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> SentinelTimeOutMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> SprintingOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> SprintingCostMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> BreakTechOnDamageOptionLocIds
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> BreakTechOnDamageMultipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public GcDifficultyConfig(long address) : base(address)
	{

	}
}
