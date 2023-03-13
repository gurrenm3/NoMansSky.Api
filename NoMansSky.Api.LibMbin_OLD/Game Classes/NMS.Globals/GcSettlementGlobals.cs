using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementGlobals : NMSTemplate
{
	public VirtualList<NMSString0x20A> ScanEventsThatPreventSentinelAlert
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public UInt64 BuildingUpgradeTimeInSeconds
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 BuildingFreeUpgradeTimeInSeconds
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 JudgementWaitTimeMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 JudgementWaitTimeMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single BuildingJudgementPriorityChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VisitorJudgementSelector
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PolicyJudgementSelector
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RequestJudgementSelector
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConflictJudgementSelector
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNPCPopulation
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DebugForceShowHiddenPerks
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SettlementEntryMessageDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 SettlementMiniExpeditionMissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single SettlementMiniExpeditionSuccessChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<UInt64> SettlementBuildingTimes
	{
		get => cache.GetOrAddValue(new VirtualArray<UInt64>(address + GetOffset(), 52));
		set => TrySetValue<UInt64>(value);
	}

	public VirtualArray<GcSettlementBuildingCost> SettlementBuildingCosts
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSettlementBuildingCost>(address + GetOffset(), 52));
		set => TrySetValue<GcSettlementBuildingCost>(value);
	}

	public VirtualList<GcSettlementJudgementData> Judgements
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementJudgementData>(address + GetOffset()));
		set => TrySetValue<GcSettlementJudgementData>(value);
	}

	public VirtualList<GcSettlementCustomJudgement> CustomJudgements
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementCustomJudgement>(address + GetOffset()));
		set => TrySetValue<GcSettlementCustomJudgement>(value);
	}

	public VirtualArray<GcSettlementStatChangeArray> SettlementBuildingStatRewards
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSettlementStatChangeArray>(address + GetOffset(), 52));
		set => TrySetValue<GcSettlementStatChangeArray>(value);
	}

	public NMSString0x10 SettlementCostGek
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SettlementCostKorvax
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SettlementCostVykeen
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MaxPerksCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinInitialPositivePerksCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxInitialPositivePerksCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinInitialNegativePerksCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxInitialNegativePerksCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> StatsMinValues
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> StatsMaxValues
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> InitialStatsMinValues
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public Int32 InitialBuildingCountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 InitialBuildingCountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> InitialStatsMaxValues
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Boolean> StatIsGoodWhenPositive
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 7));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Single> NormalisedStatBadThresholds
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 7));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> NormalisedStatGoodThresholds
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 7));
		set => TrySetValue<Single>(value);
	}

	public Colour PositiveStatColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NegativeStatColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public UInt64 ProductionSlotTimerOffsetInSeconds
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 ProductionCycleDurationInSeconds
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 AlertCycleDurationInSeconds
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 MaxProductionSlotUnits
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProductUnitsPerCycleRateModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SubstanceUnitsPerCycleRateModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 InitialDebtCycles
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DailyDebtPaymentModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AlertUnitsPerCycleRateModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> StatProductivityContributionModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Boolean> StatProductionIsNegativeWhenBad
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 7));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<NMSString0x10> PolicyPerks
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> ResearchPerks
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> AltResearchPerks
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<GcSettlementStatStrengthData> PerkStatStrengthValues
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSettlementStatStrengthData>(address + GetOffset(), 7));
		set => TrySetValue<GcSettlementStatStrengthData>(value);
	}

	public VirtualList<NMSString0x10> GekProductionElements
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> KorvaxProductionElements
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> VykeenProductionElements
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> PoorProductionElements
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> NeutralProductionElements
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> RichProductionElements
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x20A> JudgementUpdateTitles
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> JudgementUpdateMainText
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> JudgementUpdateSubtitles
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> PositiveStatChangeOSDLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> NegativeStatChangeOSDLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x10> PositiveStatChangeSubstances
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> NegativeStatChangeSubstances
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x20A> PositiveFakePerkOSDLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> NegativeFakePerkOSDLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> ProcPerkDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> ShortPolicyLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> LongPolicyLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> ShortResearchLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> LongResearchLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> ShortAltResearchLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> LongAltResearchLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcSettlementGiftDetails> GekGifts
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementGiftDetails>(address + GetOffset()));
		set => TrySetValue<GcSettlementGiftDetails>(value);
	}

	public VirtualList<GcSettlementGiftDetails> KorvaxGifts
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementGiftDetails>(address + GetOffset()));
		set => TrySetValue<GcSettlementGiftDetails>(value);
	}

	public VirtualList<GcSettlementGiftDetails> VykeenGifts
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementGiftDetails>(address + GetOffset()));
		set => TrySetValue<GcSettlementGiftDetails>(value);
	}

	public VirtualList<GcSettlementGiftDetails> Gifts
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementGiftDetails>(address + GetOffset()));
		set => TrySetValue<GcSettlementGiftDetails>(value);
	}

	public VirtualList<NMSString0x10> TechGiftPerks
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcSettlementJobDetails> JobTypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementJobDetails>(address + GetOffset()));
		set => TrySetValue<GcSettlementJobDetails>(value);
	}

	public GcSettlementGlobals(long address) : base(address)
	{

	}
}
