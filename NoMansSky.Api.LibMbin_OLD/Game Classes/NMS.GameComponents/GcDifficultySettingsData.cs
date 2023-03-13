using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultySettingsData : NMSTemplate
{
	public Boolean SettingsLocked
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InventoriesAlwaysInRange
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllSlotsUnlocked
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean WarpDriveRequirements
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CraftingIsFree
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TutorialEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean StartWithAllItemsKnown
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BaseAutoPower
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDeathConsequencesDifficultyOption DeathConsequences
	{
		get => GetValue<GcDeathConsequencesDifficultyOption>();
		set => TrySetValue<GcDeathConsequencesDifficultyOption>(value);
	}

	public GcDamageReceivedDifficultyOption DamageReceived
	{
		get => GetValue<GcDamageReceivedDifficultyOption>();
		set => TrySetValue<GcDamageReceivedDifficultyOption>(value);
	}

	public GcDamageGivenDifficultyOption DamageGiven
	{
		get => GetValue<GcDamageGivenDifficultyOption>();
		set => TrySetValue<GcDamageGivenDifficultyOption>(value);
	}

	public GcActiveSurvivalBarsDifficultyOption ActiveSurvivalBars
	{
		get => GetValue<GcActiveSurvivalBarsDifficultyOption>();
		set => TrySetValue<GcActiveSurvivalBarsDifficultyOption>(value);
	}

	public GcHazardDrainDifficultyOption HazardDrain
	{
		get => GetValue<GcHazardDrainDifficultyOption>();
		set => TrySetValue<GcHazardDrainDifficultyOption>(value);
	}

	public GcEnergyDrainDifficultyOption EnergyDrain
	{
		get => GetValue<GcEnergyDrainDifficultyOption>();
		set => TrySetValue<GcEnergyDrainDifficultyOption>(value);
	}

	public GcSubstanceCollectionDifficultyOption SubstanceCollection
	{
		get => GetValue<GcSubstanceCollectionDifficultyOption>();
		set => TrySetValue<GcSubstanceCollectionDifficultyOption>(value);
	}

	public GcInventoryStackLimitsDifficultyOption InventoryStackLimits
	{
		get => GetValue<GcInventoryStackLimitsDifficultyOption>();
		set => TrySetValue<GcInventoryStackLimitsDifficultyOption>(value);
	}

	public GcChargingRequirementsDifficultyOption ChargingRequirements
	{
		get => GetValue<GcChargingRequirementsDifficultyOption>();
		set => TrySetValue<GcChargingRequirementsDifficultyOption>(value);
	}

	public GcFuelUseDifficultyOption FuelUse
	{
		get => GetValue<GcFuelUseDifficultyOption>();
		set => TrySetValue<GcFuelUseDifficultyOption>(value);
	}

	public GcLaunchFuelCostDifficultyOption LaunchFuelCost
	{
		get => GetValue<GcLaunchFuelCostDifficultyOption>();
		set => TrySetValue<GcLaunchFuelCostDifficultyOption>(value);
	}

	public GcCurrencyCostDifficultyOption CurrencyCost
	{
		get => GetValue<GcCurrencyCostDifficultyOption>();
		set => TrySetValue<GcCurrencyCostDifficultyOption>(value);
	}

	public GcItemShopAvailabilityDifficultyOption ItemShopAvailability
	{
		get => GetValue<GcItemShopAvailabilityDifficultyOption>();
		set => TrySetValue<GcItemShopAvailabilityDifficultyOption>(value);
	}

	public GcScannerRechargeDifficultyOption ScannerRecharge
	{
		get => GetValue<GcScannerRechargeDifficultyOption>();
		set => TrySetValue<GcScannerRechargeDifficultyOption>(value);
	}

	public GcReputationGainDifficultyOption ReputationGain
	{
		get => GetValue<GcReputationGainDifficultyOption>();
		set => TrySetValue<GcReputationGainDifficultyOption>(value);
	}

	public GcCreatureHostilityDifficultyOption CreatureHostility
	{
		get => GetValue<GcCreatureHostilityDifficultyOption>();
		set => TrySetValue<GcCreatureHostilityDifficultyOption>(value);
	}

	public GcCombatTimerDifficultyOption SpaceCombatTimers
	{
		get => GetValue<GcCombatTimerDifficultyOption>();
		set => TrySetValue<GcCombatTimerDifficultyOption>(value);
	}

	public GcCombatTimerDifficultyOption GroundCombatTimers
	{
		get => GetValue<GcCombatTimerDifficultyOption>();
		set => TrySetValue<GcCombatTimerDifficultyOption>(value);
	}

	public GcSprintingCostDifficultyOption SprintingCost
	{
		get => GetValue<GcSprintingCostDifficultyOption>();
		set => TrySetValue<GcSprintingCostDifficultyOption>(value);
	}

	public GcBreakTechOnDamageDifficultyOption BreakTechOnDamage
	{
		get => GetValue<GcBreakTechOnDamageDifficultyOption>();
		set => TrySetValue<GcBreakTechOnDamageDifficultyOption>(value);
	}

	public GcDifficultySettingsData(long address) : base(address)
	{

	}
}
