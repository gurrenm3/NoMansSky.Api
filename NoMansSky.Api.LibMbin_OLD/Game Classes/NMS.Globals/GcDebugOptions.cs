using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Globals;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDebugOptions : NMSTemplate
{
	public Boolean ForceScanEventsToGoPrime
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SkipAbandonedFreighterUnlocking
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowSavingOnAbandonedFreighters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableAbandonedFreighterRoomsOptimisation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public UInt64 OverrideAbandonedFreighterSeed
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Boolean ThirdPersonIsDefaultCameraForPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ThirdPersonIsDefaultCameraForShipAndVehicles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SkipIntro
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SkipLogos
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SkipUITimers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 BootDirectlyIntoSaveSlot
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean BootDirectlyIntoLastSave
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcGameMode NewSaveGameMode
	{
		get => GetValue<GcGameMode>();
		set => TrySetValue<GcGameMode>(value);
	}

	public Boolean SkipPlanetDiscoverOnBoot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean VideoCaptureMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean GodMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TakeNoDamage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SuperKillGuns
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlwaysHaveFocus
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableVibration
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugGalaxyMapInQuickMenu
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MapWarpCheckIgnoreFuel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MapWarpCheckIgnoreDrive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EverythingIsFree
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EverythingIsKnown
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EverythingIsStar
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InfiniteStamina
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableHazards
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IgnoreMissionRank
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanLeaveDialogs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableOldMissions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseScreenEffects
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseGunImpactEffect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RenderCreatureDetails
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SkipTutorial
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IgnoreFreighterSpawnWarpRequirement
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MaximumFreighterSpawns
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableSaveSlotSorting
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableSaving
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableContinuousSaving
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableStorms
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceEnablePlayerClothComponent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceDisablePlayerClothComponent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClothForcePositionExtrapolationOff
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClothForcePositionExtrapolationOn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClothForcePositionExtrapolationBackOn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClothForcePositionExtrapolationUpdateOrderDependent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClothForcePositionExtrapolationSyncWithFpsLock
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClothForcePositionExtrapolationAntiSyncWithFpsLock
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceEnablePlayerSpringAttachmentComponent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceDisablePlayerSpringAttachmentComponent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceEnableSplitIkOptimisation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceDisableSplitIkOptimisation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableNPCs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlternateControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlwaysShowURI
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MPMissionsAlwaysEPIC
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowFireteamMembersUA
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RevealAllTitles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UnlockAllTitles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LockAllTitles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlwaysAllowShipOperations
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlwaysAllowVehicleOperations
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlwaysAllowFreighterInventoryAccess
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x200 SeasonalDataOverrideFile
	{
		get => GetValue<NMSString0x200>();
		set => TrySetValue<NMSString0x200>(value);
	}

	public Boolean UnlockAllSeasonRewards
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UnlockAllTwitchRewards
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UnlockAllPlatformRewards
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x400 DebugTwitchRewards
	{
		get => GetValue<NMSString0x400>();
		set => TrySetValue<NMSString0x400>(value);
	}

	public Boolean AllowPause
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllSettlementsAreCompleted
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableSettlements
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PlaceOnGroundWhenLeavingDebugCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OctahedralImpostersEnable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OctahedralImpostersDisable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OctahedralImpostersViewFromSpace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 OctahedralImpostersViewCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseDebugScreenSettings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ScreenWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ScreenHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DisableVSync
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.GameWindowModeEnum GameWindowMode
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.GameWindowModeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.GameWindowModeEnum>(value);
	}

	public Int32 Monitor
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TiledWindowsSplitCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TiledWindowsIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x100 ForceUniverseAddress
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 ForcePlayerPosition
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Boolean ForceInitialShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceInitialWeapon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.GameStateModeEnum GameStateMode
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.GameStateModeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.GameStateModeEnum>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.BootModeEnum BootMode
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.BootModeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.BootModeEnum>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.PlayerSpawnLocationOverrideEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.PlayerSpawnLocationOverrideEnum>(value);
	}

	public NMSString0x80 SceneSettings
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x100 WorkingDirectory
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x80 DebugScene
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.SolarSystemBootEnum SolarSystemBoot
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.SolarSystemBootEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.SolarSystemBootEnum>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.ShaderPreloadEnum ShaderPreload
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.ShaderPreloadEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.ShaderPreloadEnum>(value);
	}

	public Boolean ShaderPreloadListExport
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShaderPreloadListImport
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShaderCaching
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.BootLoadDelayEnum BootLoadDelay
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.BootLoadDelayEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.BootLoadDelayEnum>(value);
	}

	public Boolean MemCsv
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ForceTimeOfDay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ForceInitialTimeOfDay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForceSunDirectionFromPhotoMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ForceSunAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ResetForcedSaveSlotOnLoad
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MissionMessageLoggingEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseParticles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseHeavyAir
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseVolumetrics
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseClouds
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableCloudAnimation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseInstances
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseObjects
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseBuildings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseCreatures
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseElevation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseLegacyFreighters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseLegacyBuildingTable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableDayNightCycle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpawnPirates
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpawnRobots
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpawnShips
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpawnPulseEncounters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InstanceCollision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LoadMissions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MPMissions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpecialsShop
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MultiplePlayerFreightersInASystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceNexusInQuickMenu
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MissionSurveyEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllSeasonMilestonesShowComplete
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableGalaxyRecolouring
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IgnoreSteamDev
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableBaseBuildingExpandables
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MouseLookEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean StartPaused
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableDebugControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FixedFramerate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ScreenshotMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RenderHud
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableDiscoveryNaming
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugDrawPlayerInteract
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceInteractionToSettings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ForceInteractionIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean InteractionsAllwaysGivesTech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InfiniteInteractions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean StopSwitchingToSecondaryInteractions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkLanguages DebugLanguage
	{
		get => GetValue<TkLanguages>();
		set => TrySetValue<TkLanguages>(value);
	}

	public NMSString0x20 AllowedLanguagesFile
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean DoAlienLanguage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAlienRace ForceInteractionRaceTo
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.RealityModeEnum RealityMode
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.RealityModeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.RealityModeEnum>(value);
	}

	public Boolean DebugPersistentInteractions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseHighlightedOptionStyle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableMissionShop
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 RealityPresetFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public UInt16 RealityGenerationIteration
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public VirtualList<NMSString0x20> LocTableList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 DefaultSaveData
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean FormatDownloadStorageAreaOnBoot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceBasicLoadScreen
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BootLogoFadeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BootMusic
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WeaponScale3P
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LogMissingLocalisedText
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FleetDirectorAutoMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single _3dTextDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3dTextMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.RecordSettingEnum RecordSetting
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.RecordSettingEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.RecordSettingEnum>(value);
	}

	public Boolean DebugBuildingSpawns
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean StressTestLongNameDisplay
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowLongestStrings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 SaveTestingCommand
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean NeverUseBanks
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableProfanityFilter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableFileWatcher
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableShaderReload
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 RecurrenceTimeOffset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public UInt64 ForceTimeToEpoch
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public NMSString0x80 CrashDumpPath
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x20 CrashDumpIdentifier
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean EnableLivePP
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugThreatLevels
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowDebugMessages
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowFramerate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PrintAvgFrameTimes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowPositionDebug
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowGPUMemory
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowMempoolOverlay
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowMouseSmoothing
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x100 ShowUniverseAddressOnGalaxyMap
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Boolean ShowGraphs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ShowSpecificGraph
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean GraphCommandBuffer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean GraphGeneration
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean GraphFPS
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean GraphTexStreaming
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SmokeTestDumpStatsMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.SmokeTestCycleModeEnum SmokeTestCycleMode
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.SmokeTestCycleModeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.SmokeTestCycleModeEnum>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.SmokeTestScenarioEnum SmokeTestScenario
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.SmokeTestScenarioEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.SmokeTestScenarioEnum>(value);
	}

	public Boolean SmokeTestLegacyOutput
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 SmokeTestConfigPlanetPositionCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SmokeTestConfigScenarioPreambleLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmokeTestConfigScenarioLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SmokeTestFastExit
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SmokeTestCameraFly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SmokeTestOutputOnly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SmokeTestPureFlight
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 SmokeTestConfigCaptureCycles
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SmokeTestConfigCaptureDurationInSeconds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SmokeTestConfigCaptureFolderNameNumberOffset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean SmokeTestConfigRandomizePlanetSeed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SmokeTestSmokeBotEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SmokeTestSmokeBotAutoStart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 SmokeTestSmokeBotTargetWarps
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean SmokeTestPostBandwidthStats
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 SmokeTestForcePlanetDetail
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 SmokeTestRunFolder
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean CreatureChatter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CreatureErrors
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CreatureDrawVocals
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DrawCreaturesInRoutines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CompressTextures
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugIBL
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugSpotlights
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugTerrainTextures
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableShadowSwitching
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 PipelineFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PipelineFilePS4
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PipelineFileXboxOne
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PipelineFileVR
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PipelineFileVRPS4
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PipelineFileFrontend
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PipelineFileEditor
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean RenderLowFramerate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableComputePost
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableEvenOddRender
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MinGPUMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Proto2DevKit
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SimulateDisabledParticleRefractions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlwaysIncludeLocalPlayerInChatMessage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SimulateNoNetworkConnection
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.ProxyTypeEnum ProxyType
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.ProxyTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.ProxyTypeEnum>(value);
	}

	public NMSString0x80 ProxyURI
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.Globals.GcDebugOptions.ServerEnvEnum ServerEnv
	{
		get => GetValue<libMBIN.NMS.Globals.GcDebugOptions.ServerEnvEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcDebugOptions.ServerEnvEnum>(value);
	}

	public NMSString0x80 AuthBaseUrl
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean CertificateSecurityBypass
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 OverrideUsernameForDev
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Int32 DiscoveryAutoSyncIntervalSeconds
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DisableSpaceStationSpawnOnJoin
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoJoinUserEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x800 AutoJoinUserNames
	{
		get => GetValue<NMSString0x800>();
		set => TrySetValue<NMSString0x800>(value);
	}

	public Boolean AlwaysSaveGameAsClient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableMonumentDownloads
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsePadOnUnfocusedWindow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 OverrideMatchmakingVersion
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x200 LoadToBase
	{
		get => GetValue<NMSString0x200>();
		set => TrySetValue<NMSString0x200>(value);
	}

	public Boolean IgnoreTransactionTimeouts
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoJoinRandomGames
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x100 GOGLogin
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Boolean RecordNetworkStatsOnBoot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FakeHandsInMultiplayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceSmallLobby
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceTinyLobby
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 OverrideServerSeasonNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 OverrideServerSeasonEndTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean EnableSynergy
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 SynergyServer
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Int32 SynergyPort
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean ShowEditorPlacementPreview
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MaxNumDebugMessages
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean PreloadToolbox
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 DebugTextureSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseProcTextureDebugger
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ProceduralModelsShown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProceduralModelBatchSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProceduralModelFilterMatchretryCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean ProceduralModelsDeterministicSequence
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ProceduralModelsThumbnailSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x80 DebugFont
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DebugFontTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CursorTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PauseTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PlayTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 StepTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 RenderToTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean HmdEnable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 HmdPreviewScale
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean HmdTracking
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HmdStereoRender
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HmdDistortionPassthru
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 HmdMonitor
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HmdEyeBufferWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HmdEyeBufferHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HmdEyeScalePos
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdHeadScalePos
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HmdFrameShiftEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HmdUseSolidGuiPointer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BodyTurning
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HmdImmersionFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowHmdHandControllers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowTeleportEffectLocally
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableLeftHand
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableHeadConstraints
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnablePhotomodeVR
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowNGuiVR
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceExtremeWeather
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceExtremeSentinels
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceStarType
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceLoadAllWeather
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcGalaxyStarTypes ForceStarTypeTo
	{
		get => GetValue<GcGalaxyStarTypes>();
		set => TrySetValue<GcGalaxyStarTypes>(value);
	}

	public Boolean ForceBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBiomeType ForceBiomeTo
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public Boolean ForceScreenFilter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcScreenFilters ForceScreenFilterTo
	{
		get => GetValue<GcScreenFilters>();
		set => TrySetValue<GcScreenFilters>(value);
	}

	public GcBiomeSubType ForceBiomeSubTypeTo
	{
		get => GetValue<GcBiomeSubType>();
		set => TrySetValue<GcBiomeSubType>(value);
	}

	public Boolean ForceBuildingRace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAlienRace ForceBuildingRaceTo
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Boolean ForceLifeLevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlanetLife ForceLifeLevelTo
	{
		get => GetValue<GcPlanetLife>();
		set => TrySetValue<GcPlanetLife>(value);
	}

	public Boolean ForceCreatureLifeLevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceDefaultCreatureFile
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 DefaultGroundCreatureTable
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultAirCreatureTable
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultWaterCreatureTable
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultCaveCreatureTable
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlanetLife ForceCreatureLifeLevelTo
	{
		get => GetValue<GcPlanetLife>();
		set => TrySetValue<GcPlanetLife>(value);
	}

	public GcPlanetLife ForceTerrainSettings
	{
		get => GetValue<GcPlanetLife>();
		set => TrySetValue<GcPlanetLife>(value);
	}

	public Boolean ForceTerrainType
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo
	{
		get => GetValue<TkVoxelGeneratorSettingsTypes>();
		set => TrySetValue<TkVoxelGeneratorSettingsTypes>(value);
	}

	public Boolean ForcePirateSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForcePrimeTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceBinaryStar
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceTernaryStar
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcGalaxyStarAnomaly ForceAnomalyTo
	{
		get => GetValue<GcGalaxyStarAnomaly>();
		set => TrySetValue<GcGalaxyStarAnomaly>(value);
	}

	public Boolean ForcePlanetsToHaveWater
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ForceWaterObjectFileIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ForceSkyColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ForceSpaceSkyColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean ForceSpaceSkyColourRare
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ForceWaterColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ForceGrassColourIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean ModifyPlanetsInInitialSystems
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForcePlanetsToHaveNoWater
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForcePlanetsToHaveNoCaves
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForcePlanetsToHaveNoNoiseLayers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForcePlanetsToHaveNoTerrainFeatures
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceRareAsteroidSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ForceAsteroidSystemIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DisableLimits
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LimitPerRegionInstances
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LimitPerRegionBodies
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LimitGlobalInstances
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LimitGlobalBodies
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 GenerateFarLodBuildingDist
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DeferRegionBodies
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single GenerateCostDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GenerateCostAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GenerateCostLOD
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GenerateCostWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DChecksEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DChecksOutputJson
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DChecksOutputBinary
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DChecksOutputFileLine
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 FrameFlipRateDefault
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FrameFlipRateLoad
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FrameFlipRateGame
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MaxFrameRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DisableBaseBuilding
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableBaseBuildingLimits
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowGlobalPartSnapping
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BaseDownloadTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DisableBasePowerRequirements
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableBaseMovingOption
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MoveBaseIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20 AutomaticPartSpawnID
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcBaseBuildingPartStyle AutomaticPartSpawnStyle
	{
		get => GetValue<GcBaseBuildingPartStyle>();
		set => TrySetValue<GcBaseBuildingPartStyle>(value);
	}

	public Boolean AutomaticPartSpawnInactive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ProfilerPartIndexPhase
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProfilerPartIndexStride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProfilerPartIteration
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean BaseAdmin
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 BaseServerPlatform
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public UInt32 BasePayloadMultiplier
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public Boolean CrossPlatformFeaturedBases
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowMissionIdInTitle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkGlobals ToolkitGlobals
	{
		get => GetValue<TkGlobals>();
		set => TrySetValue<TkGlobals>(value);
	}

	public Boolean AllowOverrideSettlementOwnership
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x40 OverrideSettlementOwnershipUsername
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x40 OverrideSettlementOwnershipOnlineId
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Boolean BlockSettlementsNetwork
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableAccessibleUI
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisablePartialStories
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UnlockAllStories
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UnlockAllWords
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDebugOptions(long address) : base(address)
	{

	}
}
