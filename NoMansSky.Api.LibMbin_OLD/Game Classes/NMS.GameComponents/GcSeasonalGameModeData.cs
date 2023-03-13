using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeasonalGameModeData : NMSTemplate
{
	public Int32 SeasonId
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public UInt64 StartTimeUTC
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 EndTimeUTC
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 Hash
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public NMSString0x20 Title
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 Subtitle
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 Description
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20A FinalStageTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A MilestoneWithStageLocId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcGameMode GameMode
	{
		get => GetValue<GcGameMode>();
		set => TrySetValue<GcGameMode>(value);
	}

	public GcDifficultyPresetType DifficultySettingPreset
	{
		get => GetValue<GcDifficultyPresetType>();
		set => TrySetValue<GcDifficultyPresetType>(value);
	}

	public GcDifficultySettingsData DifficultyMinimums
	{
		get => GetValue<GcDifficultySettingsData>();
		set => TrySetValue<GcDifficultySettingsData>(value);
	}

	public NMSString0x20 SeasonalUAOverride
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public UInt64 UAOverrideValue
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public NMSString0x10 FinalReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 FinalRewardSwitchAlt
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A FinalCantRewardMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x200 FinalRewardDescription
	{
		get => GetValue<NMSString0x200>();
		set => TrySetValue<NMSString0x200>(value);
	}

	public TkTextureResource MainIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Int32 SeasonNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RemixNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DisplayNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A SeasonName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A SeasonNameUpper
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A MainMissionTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A MainMissionMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean DoCommunityMissionTextSubstitutions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DefaultToPvPOff
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSString0x10> AdditionalTradeProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> NeverTradeProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 StartingSuitSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 StartingSuitTechSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 StartingSuitCargoSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSeed WeaponSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcSeed ShipSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcSpaceshipClasses ShipType
	{
		get => GetValue<GcSpaceshipClasses>();
		set => TrySetValue<GcSpaceshipClasses>(value);
	}

	public Boolean StartWithFreighter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 FreighterBaseOverrideFilename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcAlienRace FreighterRace
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Boolean StartAboardFreighter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcBuildingClassification> ValidSpawnBuildings
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingClassification>(address + GetOffset()));
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public GcInventoryLayout WeaponInventoryLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout ShipInventoryLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout ShipTechInventoryLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public Boolean UseDefaultAppearance
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInventoryContainer Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer Inventory_TechOnly
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer Inventory_Cargo
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer ShipInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer WeaponInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public Boolean UseRandomPet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcSeasonPetConstraints> RandomPetConstraints
	{
		get => cache.GetOrAddValue(new VirtualList<GcSeasonPetConstraints>(address + GetOffset()));
		set => TrySetValue<GcSeasonPetConstraints>(value);
	}

	public VirtualArray<GcPetData> SpecificPets
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetData>(address + GetOffset(), 18));
		set => TrySetValue<GcPetData>(value);
	}

	public VirtualList<GcSandwormTimerAndFrequencyOverride> SandwormOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcSandwormTimerAndFrequencyOverride>(address + GetOffset()));
		set => TrySetValue<GcSandwormTimerAndFrequencyOverride>(value);
	}

	public Boolean SandwormGlobalOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SandwormGlobalOverrideTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandwormGlobalOverrideSpawnChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean StartNextToShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DistanceFromShipAtStartOfGame
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShipStartsDamaged
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowMissionDetailMessages
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseStartPlanetObjectListOverrides
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 StartPlanetRareSubstanceOverride
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean TrashInventoryOnGalaxyTravel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 FreighterBattleEarlyWarpsOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean ForceDeepSpaceAmbientFrigatesOnInfested
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 TechCostMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x10> NeverLearnableTech
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> ForgottenProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean IncreaseXClassTechOddsWithCommTier
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AbandonedFreighterHazardProtectionMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardProtectionDrainMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyDrainMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 QuestSubstanceReducer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcSeasonalStage> Stages
	{
		get => cache.GetOrAddValue(new VirtualList<GcSeasonalStage>(address + GetOffset()));
		set => TrySetValue<GcSeasonalStage>(value);
	}

	public GcScanEventTable ScanEventTable
	{
		get => GetValue<GcScanEventTable>();
		set => TrySetValue<GcScanEventTable>(value);
	}

	public Boolean ResetSaveOnDeath
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcPersistedStatData> StatsToPersistOnReset
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistedStatData>(address + GetOffset()));
		set => TrySetValue<GcPersistedStatData>(value);
	}

	public Boolean CompatibleWithState
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasBeenConverted
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcTechnology> TechnologyTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcTechnology>(address + GetOffset()));
		set => TrySetValue<GcTechnology>(value);
	}

	public VirtualList<GcProductData> ProductTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcProductData>(address + GetOffset()));
		set => TrySetValue<GcProductData>(value);
	}

	public VirtualList<GcRealitySubstanceData> SubstanceTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcRealitySubstanceData>(address + GetOffset()));
		set => TrySetValue<GcRealitySubstanceData>(value);
	}

	public GcSeasonalGameModeData(long address) : base(address)
	{

	}
}
