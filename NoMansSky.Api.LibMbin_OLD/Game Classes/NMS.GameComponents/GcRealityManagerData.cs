using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRealityManagerData : NMSTemplate
{
	public UInt16 HomeRealityIteration
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public UInt16 RealityIteration
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public VirtualArray<GcDiscoveryWorth> DiscoveryWorth
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDiscoveryWorth>(address + GetOffset(), 17));
		set => TrySetValue<GcDiscoveryWorth>(value);
	}

	public VirtualArray<Single> CreatureDiscoverySizeMultiplier
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups
	{
		get => cache.GetOrAddValue(new VirtualList<GcSubstanceSecondaryLookup>(address + GetOffset()));
		set => TrySetValue<GcSubstanceSecondaryLookup>(value);
	}

	public GcSubstanceSecondaryBiome SubstanceSecondaryBiome
	{
		get => GetValue<GcSubstanceSecondaryBiome>();
		set => TrySetValue<GcSubstanceSecondaryBiome>(value);
	}

	public NMSString0x80 TechnologyTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 SubstanceTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ProductTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ProceduralProductTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ProceduralTechnologyTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 LegacyItemConversionTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<TkRawID> LegacyRepairTable
	{
		get => cache.GetOrAddValue(new VirtualList<TkRawID>(address + GetOffset()));
		set => TrySetValue<TkRawID>(value);
	}

	public NMSString0x80 ConsumableItemTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 RecipeTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 StoriesTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DialogClearanceTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 AlienWordsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<NMSString0x80> AlienPuzzleTables
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<Boolean> LoopInteractionPuzzles
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 131));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcAlienPuzzleTableIndex> InteractionPuzzlesIndexTypes
	{
		get => cache.GetOrAddValue(new VirtualArray<GcAlienPuzzleTableIndex>(address + GetOffset(), 131));
		set => TrySetValue<GcAlienPuzzleTableIndex>(value);
	}

	public VirtualArray<TkCurveType> WeightingCurves
	{
		get => cache.GetOrAddValue(new VirtualArray<TkCurveType>(address + GetOffset(), 7));
		set => TrySetValue<TkCurveType>(value);
	}

	public VirtualList<GcDamageMultiplierLookup> DamageMultiplierTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcDamageMultiplierLookup>(address + GetOffset()));
		set => TrySetValue<GcDamageMultiplierLookup>(value);
	}

	public NMSString0x80 RewardTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DiscoveryRewardTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 InventoryTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DamageTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PurchaseableBuildingBlueprintsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PurchaseableSpecialsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 UnlockableSeasonRewardsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 UnlockableTwitchRewardsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 UnlockablePlatformRewardsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CostTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 TradingCostTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 TradingClassDataTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 MaintenanceGroupsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 UnlockableItemTrees
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 SettlementPerksTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PlayerWeaponPropertiesTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CombatEffectsTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 TechBoxTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcFreighterCargoOption> FreighterCargoOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcFreighterCargoOption>(address + GetOffset()));
		set => TrySetValue<GcFreighterCargoOption>(value);
	}

	public VirtualArray<GcShipWeaponData> ShipWeapons
	{
		get => cache.GetOrAddValue(new VirtualArray<GcShipWeaponData>(address + GetOffset(), 7));
		set => TrySetValue<GcShipWeaponData>(value);
	}

	public VirtualArray<GcPlayerWeaponData> PlayerWeapons
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerWeaponData>(address + GetOffset(), 19));
		set => TrySetValue<GcPlayerWeaponData>(value);
	}

	public VirtualArray<TkIdArray> DefaultVehicleLoadout
	{
		get => cache.GetOrAddValue(new VirtualArray<TkIdArray>(address + GetOffset(), 7));
		set => TrySetValue<TkIdArray>(value);
	}

	public VirtualArray<NMSString0x10> FactionStandingIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 9));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x20A> FactionNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 9));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<GcNumberedTextList> FactionClients
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNumberedTextList>(address + GetOffset(), 9));
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public VirtualArray<GcNumberedTextList> MissionNameFormats
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNumberedTextList>(address + GetOffset(), 11));
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public VirtualArray<GcNumberedTextList> MissionNameAdjectives
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNumberedTextList>(address + GetOffset(), 11));
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public VirtualArray<GcNumberedTextList> MissionNameNouns
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNumberedTextList>(address + GetOffset(), 11));
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public VirtualArray<TkIdArray> MissionBoardRewardOptions
	{
		get => cache.GetOrAddValue(new VirtualArray<TkIdArray>(address + GetOffset(), 11));
		set => TrySetValue<TkIdArray>(value);
	}

	public VirtualArray<Single> WeightedTextWeights
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public GcRealityIconTable Icons
	{
		get => GetValue<GcRealityIconTable>();
		set => TrySetValue<GcRealityIconTable>(value);
	}

	public VirtualArray<Colour> HazardColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 6));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> RarityColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 3));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> SubstanceCategoryColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 9));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<TkTextureResource> SubstanceChargeIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 9));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> StatCategoryIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 189));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> StatTechPackageIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 189));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<GcStats> Stats
	{
		get => cache.GetOrAddValue(new VirtualArray<GcStats>(address + GetOffset(), 5));
		set => TrySetValue<GcStats>(value);
	}

	public GcTechList StationTechShops
	{
		get => GetValue<GcTechList>();
		set => TrySetValue<GcTechList>(value);
	}

	public VirtualArray<GcTechList> PlanetTechShops
	{
		get => cache.GetOrAddValue(new VirtualArray<GcTechList>(address + GetOffset(), 16));
		set => TrySetValue<GcTechList>(value);
	}

	public GcTradeSettings TradeSettings
	{
		get => GetValue<GcTradeSettings>();
		set => TrySetValue<GcTradeSettings>(value);
	}

	public VirtualList<NMSString0x10> PirateStationExtraProds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcInventoryLayout SuitStartingSlotLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout SuitTechOnlyStartingSlotLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout SuitCargoStartingSlotLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout ShipStartingLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout ShipTechOnlyStartingLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout ShipCargoOnlyStartingLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public VirtualList<Int32> SuitUpgradePrices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> SuitTechOnlyUpgradePrices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> SuitCargoUpgradePrices
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x10> NeverSellableItems
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> NeverOfferedForSale
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<Single> NormalisedPriceLimits
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcFiendCrimeSpawnTable>(address + GetOffset()));
		set => TrySetValue<GcFiendCrimeSpawnTable>(value);
	}

	public VirtualList<GcIDPair> FreighterBaseItemPairs
	{
		get => cache.GetOrAddValue(new VirtualList<GcIDPair>(address + GetOffset()));
		set => TrySetValue<GcIDPair>(value);
	}

	public VirtualArray<NMSString0x80> Catalogues
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 5));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcRealityManagerData(long address) : base(address)
	{

	}
}
