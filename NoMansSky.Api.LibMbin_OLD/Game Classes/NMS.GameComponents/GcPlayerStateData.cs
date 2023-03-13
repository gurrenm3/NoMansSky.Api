using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerStateData : NMSTemplate
{
	public GcUniverseAddressData UniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public GcUniverseAddressData PreviousUniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public Int32 HomeRealityIteration
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x80 SaveName
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 SaveSummary
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcDifficultyStateData DifficultyState
	{
		get => GetValue<GcDifficultyStateData>();
		set => TrySetValue<GcDifficultyStateData>(value);
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

	public VirtualArray<GcMultitoolData> Multitools
	{
		get => cache.GetOrAddValue(new VirtualArray<GcMultitoolData>(address + GetOffset(), 6));
		set => TrySetValue<GcMultitoolData>(value);
	}

	public Int32 ActiveMultioolIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcByteBeatLibraryData ByteBeatLibrary
	{
		get => GetValue<GcByteBeatLibraryData>();
		set => TrySetValue<GcByteBeatLibraryData>(value);
	}

	public VirtualArray<GcPetData> Pets
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetData>(address + GetOffset(), 18));
		set => TrySetValue<GcPetData>(value);
	}

	public VirtualArray<GcPetData> Eggs
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetData>(address + GetOffset(), 18));
		set => TrySetValue<GcPetData>(value);
	}

	public VirtualArray<GcPetCustomisationData> PetAccessoryCustomisation
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetCustomisationData>(address + GetOffset(), 18));
		set => TrySetValue<GcPetCustomisationData>(value);
	}

	public VirtualArray<Boolean> UnlockedPetSlots
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 18));
		set => TrySetValue<Boolean>(value);
	}

	public GcInventoryContainer GraveInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public Boolean SpawnGrave
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceGrave
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcUniverseAddressData GraveUniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public Vector4f GravePosition
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f GraveMatrixLookAt
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f GraveMatrixUp
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public GcInventoryLayout ShipLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout WeaponLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcResourceElement CurrentShip
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcExactResource CurrentWeapon
	{
		get => GetValue<GcExactResource>();
		set => TrySetValue<GcExactResource>(value);
	}

	public VirtualList<NMSString0x10> KnownTech
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> KnownProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> KnownSpecials
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x20A> KnownRefinerRecipes
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcWordKnowledge> KnownWords
	{
		get => cache.GetOrAddValue(new VirtualList<GcWordKnowledge>(address + GetOffset()));
		set => TrySetValue<GcWordKnowledge>(value);
	}

	public VirtualList<GcWordGroupKnowledge> KnownWordGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcWordGroupKnowledge>(address + GetOffset()));
		set => TrySetValue<GcWordGroupKnowledge>(value);
	}

	public VirtualList<GcPlayerMissionProgress> MissionProgress
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerMissionProgress>(address + GetOffset()));
		set => TrySetValue<GcPlayerMissionProgress>(value);
	}

	public Int32 PostMissionIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 CurrentMissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public UInt64 CurrentMissionSeed
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public NMSString0x10 PreviousMissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public UInt64 PreviousMissionSeed
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 MissionVersion
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcMissionIDEpochPair> MissionRecurrences
	{
		get => cache.GetOrAddValue(new VirtualList<GcMissionIDEpochPair>(address + GetOffset()));
		set => TrySetValue<GcMissionIDEpochPair>(value);
	}

	public GcInteractionData HoloExplorerInteraction
	{
		get => GetValue<GcInteractionData>();
		set => TrySetValue<GcInteractionData>(value);
	}

	public GcInteractionData HoloScepticInteraction
	{
		get => GetValue<GcInteractionData>();
		set => TrySetValue<GcInteractionData>(value);
	}

	public GcInteractionData HoloNooneInteraction
	{
		get => GetValue<GcInteractionData>();
		set => TrySetValue<GcInteractionData>(value);
	}

	public Int32 Health
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShipHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Shield
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShipShield
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Energy
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Units
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Nanites
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Specials
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean ThirdPersonShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public UInt64 TimeAlive
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 TotalPlayTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<GcScanEventSave> MarkerStack
	{
		get => cache.GetOrAddValue(new VirtualList<GcScanEventSave>(address + GetOffset()));
		set => TrySetValue<GcScanEventSave>(value);
	}

	public VirtualList<GcScanEventSave> NewMPMarkerStack
	{
		get => cache.GetOrAddValue(new VirtualList<GcScanEventSave>(address + GetOffset()));
		set => TrySetValue<GcScanEventSave>(value);
	}

	public VirtualList<Vector3f> SurveyedEventPositions
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public Int32 NextSurveyedEventPositionIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcPlayerStatsGroup> Stats
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerStatsGroup>(address + GetOffset()));
		set => TrySetValue<GcPlayerStatsGroup>(value);
	}

	public VirtualList<GcTelemetryStat> TelemetryStats
	{
		get => cache.GetOrAddValue(new VirtualList<GcTelemetryStat>(address + GetOffset()));
		set => TrySetValue<GcTelemetryStat>(value);
	}

	public VirtualArray<GcInteractionBuffer> StoredInteractions
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInteractionBuffer>(address + GetOffset(), 11));
		set => TrySetValue<GcInteractionBuffer>(value);
	}

	public VirtualList<GcMaintenanceContainer> MaintenanceInteractions
	{
		get => cache.GetOrAddValue(new VirtualList<GcMaintenanceContainer>(address + GetOffset()));
		set => TrySetValue<GcMaintenanceContainer>(value);
	}

	public VirtualList<GcMaintenanceContainer> PersonalMaintenanceInteractions
	{
		get => cache.GetOrAddValue(new VirtualList<GcMaintenanceContainer>(address + GetOffset()));
		set => TrySetValue<GcMaintenanceContainer>(value);
	}

	public VirtualList<UInt64> VisitedSystems
	{
		get => cache.GetOrAddValue(new VirtualList<UInt64>(address + GetOffset()));
		set => TrySetValue<UInt64>(value);
	}

	public VirtualArray<Single> Hazard
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 6));
		set => TrySetValue<Single>(value);
	}

	public Int32 BoltAmmo
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ScatterAmmo
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PulseAmmo
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LaserAmmo
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector4f FirstSpawnPosition
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public VirtualArray<GcSavedInteractionRaceData> SavedInteractionIndicies
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSavedInteractionRaceData>(address + GetOffset(), 131));
		set => TrySetValue<GcSavedInteractionRaceData>(value);
	}

	public VirtualList<GcSavedInteractionDialogData> SavedInteractionDialogTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcSavedInteractionDialogData>(address + GetOffset()));
		set => TrySetValue<GcSavedInteractionDialogData>(value);
	}

	public VirtualList<NMSString0x20A> InteractionProgressTable
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<GcUniverseAddressData> AtlasStationAdressData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcUniverseAddressData>(address + GetOffset(), 10));
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public VirtualArray<GcUniverseAddressData> NewAtlasStationAdressData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcUniverseAddressData>(address + GetOffset(), 11));
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public VirtualList<GcUniverseAddressData> VisitedAtlasStationsData
	{
		get => cache.GetOrAddValue(new VirtualList<GcUniverseAddressData>(address + GetOffset()));
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public Boolean FirstAtlasStationDiscovered
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesThirdPersonCharacterCam
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ProgressionLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProcTechIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean IsNew
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseSmallerBlackholeJumps
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcSavedEntitlement> UsedEntitlements
	{
		get => cache.GetOrAddValue(new VirtualList<GcSavedEntitlement>(address + GetOffset()));
		set => TrySetValue<GcSavedEntitlement>(value);
	}

	public VirtualArray<Vector3f> PlanetPositions
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector3f>(address + GetOffset(), 16));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualArray<GcSeed> PlanetSeeds
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSeed>(address + GetOffset(), 16));
		set => TrySetValue<GcSeed>(value);
	}

	public Int32 PrimaryPlanet
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public UInt64 TimeLastSpaceBattle
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 WarpsLastSpaceBattle
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public UInt64 ActiveSpaceBattleUA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 TimeLastMiniStation
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 WarpsLastMiniStation
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public UInt64 MiniStationUA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Vector4f AnomalyPositionOverride
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public GcUniverseAddressData GameStartAddress1
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public GcUniverseAddressData GameStartAddress2
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public VirtualArray<Boolean> GalacticMapRequests
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 16));
		set => TrySetValue<Boolean>(value);
	}

	public Vector4f FirstShipPosition
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public UInt64 HazardTimeAlive
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Boolean RevealBlackHoles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSeed CurrentFreighterHomeSystemSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcResourceElement CurrentFreighter
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcInventoryLayout FreighterLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryLayout FreighterCargoLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer FreighterInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer FreighterInventory_TechOnly
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer FreighterInventory_Cargo
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public UInt64 FreighterLastSpawnTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcUniverseAddressData FreighterUniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public Boolean FreighterDismissed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f FreighterMatrixAt
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f FreighterMatrixUp
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f FreighterMatrixPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualArray<Boolean> SquadronUnlockedPilotSlots
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 4));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcSquadronPilotData> SquadronPilots
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSquadronPilotData>(address + GetOffset(), 4));
		set => TrySetValue<GcSquadronPilotData>(value);
	}

	public VirtualList<NMSString0x10> SeenBaseBuildingObjects
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcPersistentBBObjectData> BaseBuildingObjects
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistentBBObjectData>(address + GetOffset()));
		set => TrySetValue<GcPersistentBBObjectData>(value);
	}

	public GcTerrainEditsBuffer TerrainEditData
	{
		get => GetValue<GcTerrainEditsBuffer>();
		set => TrySetValue<GcTerrainEditsBuffer>(value);
	}

	public VirtualArray<GcNPCWorkerData> NPCWorkers
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNPCWorkerData>(address + GetOffset(), 5));
		set => TrySetValue<GcNPCWorkerData>(value);
	}

	public VirtualList<GcPersistentBase> PersistentPlayerBases
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistentBase>(address + GetOffset()));
		set => TrySetValue<GcPersistentBase>(value);
	}

	public VirtualList<GcTeleportEndpoint> TeleportEndpoints
	{
		get => cache.GetOrAddValue(new VirtualList<GcTeleportEndpoint>(address + GetOffset()));
		set => TrySetValue<GcTeleportEndpoint>(value);
	}

	public GcInventoryLayout Chest1Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest1Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest2Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest2Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest3Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest3Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest4Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest4Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest5Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest5Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest6Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest6Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest7Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest7Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest8Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest8Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest9Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest9Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout Chest10Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Chest10Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout ChestMagicLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer ChestMagicInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout ChestMagic2Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer ChestMagic2Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout CookingIngredientsLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer CookingIngredientsInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout RocketLockerLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer RocketLockerInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcResourceElement CurrentFreighterNPC
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public VirtualArray<GcPlayerOwnershipData> VehicleOwnership
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerOwnershipData>(address + GetOffset(), 7));
		set => TrySetValue<GcPlayerOwnershipData>(value);
	}

	public Int32 PrimaryVehicle
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<GcPlayerOwnershipData> ShipOwnership
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerOwnershipData>(address + GetOffset(), 9));
		set => TrySetValue<GcPlayerOwnershipData>(value);
	}

	public Int32 PrimaryShip
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean MultiShipEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean VehicleAIControlEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 PlayerFreighterName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Vector4f StartGameShipPosition
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Boolean ShipNeedsTerrainPositioning
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 TradingSupplyDataIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcTradingSupplyData> TradingSupplyData
	{
		get => cache.GetOrAddValue(new VirtualList<GcTradingSupplyData>(address + GetOffset()));
		set => TrySetValue<GcTradingSupplyData>(value);
	}

	public VirtualList<GcPortalSaveData> LastPortal
	{
		get => cache.GetOrAddValue(new VirtualList<GcPortalSaveData>(address + GetOffset()));
		set => TrySetValue<GcPortalSaveData>(value);
	}

	public GcPortalSaveData VisitedPortal
	{
		get => GetValue<GcPortalSaveData>();
		set => TrySetValue<GcPortalSaveData>(value);
	}

	public Int32 KnownPortalRunes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean OnOtherSideOfPortal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcTeleportEndpoint OtherSideOfPortalReturnBase
	{
		get => GetValue<GcTeleportEndpoint>();
		set => TrySetValue<GcTeleportEndpoint>(value);
	}

	public Vector4f PortalMarkerPosition_Local
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f PortalMarkerPosition_Offset
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public GcPlayerWeapons StartingPrimaryWeapon
	{
		get => GetValue<GcPlayerWeapons>();
		set => TrySetValue<GcPlayerWeapons>(value);
	}

	public GcPlayerWeapons StartingSecondaryWeapon
	{
		get => GetValue<GcPlayerWeapons>();
		set => TrySetValue<GcPlayerWeapons>(value);
	}

	public VirtualArray<GcCharacterCustomisationSaveData> CharacterCustomisationData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCharacterCustomisationSaveData>(address + GetOffset(), 20));
		set => TrySetValue<GcCharacterCustomisationSaveData>(value);
	}

	public VirtualArray<Boolean> ShipUsesLegacyColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 9));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcCharacterCustomisationData> Outfits
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCharacterCustomisationData>(address + GetOffset(), 3));
		set => TrySetValue<GcCharacterCustomisationData>(value);
	}

	public NMSString0x10 JetpackEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 FreighterEngineEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSeed FleetSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public VirtualList<GcFleetFrigateSaveData> FleetFrigates
	{
		get => cache.GetOrAddValue(new VirtualList<GcFleetFrigateSaveData>(address + GetOffset()));
		set => TrySetValue<GcFleetFrigateSaveData>(value);
	}

	public VirtualList<GcFleetExpeditionSaveData> FleetExpeditions
	{
		get => cache.GetOrAddValue(new VirtualList<GcFleetExpeditionSaveData>(address + GetOffset()));
		set => TrySetValue<GcFleetExpeditionSaveData>(value);
	}

	public VirtualList<UInt64> ExpeditionSeedsSelectedToday
	{
		get => cache.GetOrAddValue(new VirtualList<UInt64>(address + GetOffset()));
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 LastKnownDay
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 SunTimer
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 MultiplayerLobbyID
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcUniverseAddressData MultiplayerUA
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public GcPlayerSpawnStateData MultiplayerSpawn
	{
		get => GetValue<GcPlayerSpawnStateData>();
		set => TrySetValue<GcPlayerSpawnStateData>(value);
	}

	public VirtualList<GcRepairTechData> RepairTechBuffer
	{
		get => cache.GetOrAddValue(new VirtualList<GcRepairTechData>(address + GetOffset()));
		set => TrySetValue<GcRepairTechData>(value);
	}

	public UInt64 MultiplayerPrivileges
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualArray<GcHotActionsSaveData> HotActions
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHotActionsSaveData>(address + GetOffset(), 3));
		set => TrySetValue<GcHotActionsSaveData>(value);
	}

	public UInt64 LastUABeforePortalWarp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 StoryPortalSeed
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt16 ShopNumber
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public UInt16 ShopTier
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public Boolean HasAccessToNexus
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcUniverseAddressData NexusUniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public Vector3f NexusMatrixAt
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f NexusMatrixUp
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f NexusMatrixPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcPhotoModeSettings PhotoModeSettings
	{
		get => GetValue<GcPhotoModeSettings>();
		set => TrySetValue<GcPhotoModeSettings>(value);
	}

	public Int32 BannerIcon
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BannerMainColour
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BannerBackgroundColour
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 BannerTitleId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 TelemetryUploadVersion
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UsesThirdPersonVehicleCam
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single VRCameraOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSeasonalGameModeData SeasonData
	{
		get => GetValue<GcSeasonalGameModeData>();
		set => TrySetValue<GcSeasonalGameModeData>(value);
	}

	public GcSeasonStateData SeasonState
	{
		get => GetValue<GcSeasonStateData>();
		set => TrySetValue<GcSeasonStateData>(value);
	}

	public Boolean RestartAllInactiveSeasonalMissions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSString0x10> RedeemedSeasonRewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> RedeemedTwitchRewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> RedeemedPlatformRewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<GcSettlementState> SettlementStatesV2
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSettlementState>(address + GetOffset(), 100));
		set => TrySetValue<GcSettlementState>(value);
	}

	public Int32 SettlementStateRingBufferIndexV2
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean NextLoadSpawnsWithFreshStart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcStoryPageSeenDataArray> SeenStories
	{
		get => cache.GetOrAddValue(new VirtualArray<GcStoryPageSeenDataArray>(address + GetOffset(), 8));
		set => TrySetValue<GcStoryPageSeenDataArray>(value);
	}

	public GcPlayerStateData(long address) : base(address)
	{

	}
}
