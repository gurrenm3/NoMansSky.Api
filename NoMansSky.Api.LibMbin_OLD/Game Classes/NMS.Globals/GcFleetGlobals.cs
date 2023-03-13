using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFleetGlobals : NMSTemplate
{
	public Vector3f FreighterCustomiserSunAngleAdjust
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public NMSString0x20A CivilianMPMissionGiverPuzzle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single MaxPurchaseDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SingleShipFlybyDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SingleShipFlybyMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SingleShipFlybyHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceForSingleShipFlybyCommsReset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceForPurchaseReset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatFrigateSpawnMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatFrigateSpawnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatNotificationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatDefenderSpawnDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PostCombatSpawnDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatSpawnDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> CombatSpawnDelayIncreaseByInventoryClass
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Int32 ExplorationPointsRequiredForScan
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInteractionDof FleetInteractionDepthOfField
	{
		get => GetValue<GcInteractionDof>();
		set => TrySetValue<GcInteractionDof>(value);
	}

	public Int32 PercentChangeOfFrigateBeingPurchasable
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A FleetCommunicationOSDMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 MinFrigateStatValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxFrigateStatValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MinFrigateDistanceFromFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFrigateDistanceFromFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigateDistanceMultiplierIfNoCaptialShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PercentChanceOfFrigateAdditionalSpawnedTrait
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaximumSpeedDecrease
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaximumSpeedIncrease
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CameraPauseAfterStartingExpedition
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UITraitLinesAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcFrigateUITraitLines> UITraitLineLengths
	{
		get => cache.GetOrAddValue(new VirtualList<GcFrigateUITraitLines>(address + GetOffset()));
		set => TrySetValue<GcFrigateUITraitLines>(value);
	}

	public VirtualList<NMSString0x20> RacialTermForCaptain
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single TimeBeforeShowingHangar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeBeforeHidingHangar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumberOfShipsInInitialFleet
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean NewFrigatesStartDamaged
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ExpeditionsCompleteInstantly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowSeeds
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisablePlayerFleets
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A DebugInterventionEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.Globals.GcFleetGlobals.ForceDebriefEntryTypeEnum ForceDebriefEntryType
	{
		get => GetValue<libMBIN.NMS.Globals.GcFleetGlobals.ForceDebriefEntryTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcFleetGlobals.ForceDebriefEntryTypeEnum>(value);
	}

	public Int32 ForcedSequentialEventsStartingIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NextDebriefDescriptionOffset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single LevelupProgressRequiredToNotBeSadAboutDamage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeBeforePlayerAlertedToDamagedFrigates
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamagedListEntryPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NonUrgentDamagedListEntryAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 LowDamageNumberOfExpeditions
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RampDamageNumberOfExpeditions
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector2f PercentChanceOfDamageOnFailedEvent
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 PercentChanceOfGenericEventDescription
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PercentChanceOfPrimaryDescriptionForBalancedEvent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcNumberedTextList FrigateDamageDescriptions
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList FrigateGoodMoods
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList FrigateBadMoods
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public VirtualArray<GcNumberedTextList> DeepSpaceFrigateMoods
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNumberedTextList>(address + GetOffset(), 11));
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList FrigateExtraNotes
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public Single RadiusRequiredForFrigateSpawn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDelayForNewFrigates
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDelayForFleetFrigates
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDelayForReturningFrigates
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDelayRandomMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDelayRandomMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDelayIncreasePerFrigate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DespawnDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DespawnDelayIncreasePerFrigate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigatesPerSecondForInstantSpawn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HologramSwapSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A TerminalNeedsAssignmentPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TerminalInterventionPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TerminalDamagePuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TerminalActivePuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TerminalDebriefPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NormandyActivePuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NormandyDebriefPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DeepSpaceFrigateActivePuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NeedFrigatesPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NewExpeditionsAvailablePuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NeedExpeditionTerminalPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A SelectExpeditionPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 NumberOfExpeditionChoices
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ExpeditionDifficultyVariance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ExpeditionDifficultyIncreaseForEachAdditionalFrigate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinExpeditionStatValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxExpeditionStatValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumberOfFrigatesPurchasedToEndEasyExpeditions
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TimeTakenForExpeditionEvent_Easy
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TimeTakenForExpeditionEvent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LightYearsPerExpeditionEvent_Easy
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LightYearsPerExpeditionEvent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumberOfUAChangesPerExpeditionEvent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TimeBetweenPassiveIncomeTicks
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcExpeditionPaymentToken> FreighterTokenProductIDs
	{
		get => cache.GetOrAddValue(new VirtualList<GcExpeditionPaymentToken>(address + GetOffset()));
		set => TrySetValue<GcExpeditionPaymentToken>(value);
	}

	public GcPassiveFrigateIncomeArray PassiveIncomes
	{
		get => GetValue<GcPassiveFrigateIncomeArray>();
		set => TrySetValue<GcPassiveFrigateIncomeArray>(value);
	}

	public VirtualList<GcExpeditionPowerup> Powerups
	{
		get => cache.GetOrAddValue(new VirtualList<GcExpeditionPowerup>(address + GetOffset()));
		set => TrySetValue<GcExpeditionPowerup>(value);
	}

	public Int32 FreighterTokenMinimumSpend
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PercentChanceOfInterventionEvent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FirstEventIndexWhichCanBeIntervention
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TimeBeforePlayerAlertedToInterventionEvent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxDiceRollWhenCalculatingExpeditionEventResult
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DifficultyMultiplierForBalancedExpeditions
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DifficultyMultiplierForNonPrimaryEvents
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 StatPointsAwardedForLevelUp
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinGapBetweenExpeditionLogEntries
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxGapBetweenExpeditionLogEntries
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TimeBetweenDebriefLettersAppearing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeBetweenDebriefLogSectionsAppearing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeBetweenDebriefLogsAppearing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeBeforeDebriefLogsStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowMissingRewardDescriptions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A CommunicatorDamagePuzzleTableEntry
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A FrigateDamagePuzzleTableEntry
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A FrigatePurchasePuzzleTableEntry
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<Int32> DifficultyModifier
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcExpeditionDebriefPunctuation> DebriefPunctuationList
	{
		get => cache.GetOrAddValue(new VirtualList<GcExpeditionDebriefPunctuation>(address + GetOffset()));
		set => TrySetValue<GcExpeditionDebriefPunctuation>(value);
	}

	public GcExpeditionDurationValues ExpeditionDurations
	{
		get => GetValue<GcExpeditionDurationValues>();
		set => TrySetValue<GcExpeditionDurationValues>(value);
	}

	public GcFrigateClassCost FrigateBaseCost
	{
		get => GetValue<GcFrigateClassCost>();
		set => TrySetValue<GcFrigateClassCost>(value);
	}

	public GcFrigateClassCost FrigateCostVariance
	{
		get => GetValue<GcFrigateClassCost>();
		set => TrySetValue<GcFrigateClassCost>(value);
	}

	public GcInventoryClassCostMultiplier FrigateCostMultiplier
	{
		get => GetValue<GcInventoryClassCostMultiplier>();
		set => TrySetValue<GcInventoryClassCostMultiplier>(value);
	}

	public GcFrigateTraitStrengthByType FrigateTraitStrengths
	{
		get => GetValue<GcFrigateTraitStrengthByType>();
		set => TrySetValue<GcFrigateTraitStrengthByType>(value);
	}

	public GcFrigateStatsByClass FrigateInitialStats
	{
		get => GetValue<GcFrigateStatsByClass>();
		set => TrySetValue<GcFrigateStatsByClass>(value);
	}

	public GcFrigateTraitIcons TraitIcons
	{
		get => GetValue<GcFrigateTraitIcons>();
		set => TrySetValue<GcFrigateTraitIcons>(value);
	}

	public GcFrigateTraitIcons NegativeTraitIcons
	{
		get => GetValue<GcFrigateTraitIcons>();
		set => TrySetValue<GcFrigateTraitIcons>(value);
	}

	public GcScanEffectData FrigateScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData FrigateHologramScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData CompletedFrigateHologramScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData DamagedFrigateHologramScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData DestroyedFrigateHologramScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance
	{
		get => GetValue<GcExpeditionEventOccurrenceRate>();
		set => TrySetValue<GcExpeditionEventOccurrenceRate>(value);
	}

	public VirtualList<NMSString0x80> FrigateHologramModels
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<NMSString0x80> FrigatePlanetModels
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<Int32> ExpeditionRankBoundaries
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> FrigateLevelVictoriesRequired
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes
	{
		get => cache.GetOrAddValue(new VirtualList<GcExpeditionDifficultyKeyframe>(address + GetOffset()));
		set => TrySetValue<GcExpeditionDifficultyKeyframe>(value);
	}

	public VirtualList<NMSString0x80> FrigateInteriorsToCache
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 NormandyFailures
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NormandyDamageEvents
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x10> NormandyTraits
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> DeepSpaceFrigateTraits
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> DeepSpaceCommonPrimaryTraits
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x20> FrigateCaptainPuzzleIds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public Int32 MaxNumberOfPlayerShipsInFreighterHangar
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcFleetGlobals(long address) : base(address)
	{

	}
}
