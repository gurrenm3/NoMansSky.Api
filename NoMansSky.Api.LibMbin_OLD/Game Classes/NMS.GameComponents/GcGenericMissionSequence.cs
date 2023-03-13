using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGenericMissionSequence : NMSTemplate
{
	public NMSString0x10 MissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcGenericMissionSequence.MissionClassEnum MissionClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.MissionClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.MissionClassEnum>(value);
	}

	public Boolean MissionIsCritical
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 MissionObjective
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcNumberedTextList MissionTitles
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList MissionSubtitles
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList MissionDescriptions
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList MissionProcDescriptionHeader
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList MissionProcDescriptionA
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList MissionProcDescriptionB
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList MissionProcDescriptionC
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public Boolean UseScanEventDetailsInLogInfo
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkTextureResource MissionIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource MissionIconSelected
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource MissionIconNotSelected
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Int32 MissionPriority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionCategory MissionCategory
	{
		get => GetValue<GcMissionCategory>();
		set => TrySetValue<GcMissionCategory>(value);
	}

	public GcMissionPageHint MissionPageHint
	{
		get => GetValue<GcMissionPageHint>();
		set => TrySetValue<GcMissionPageHint>(value);
	}

	public NMSString0x20A MissionPageLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 MissionBuildMenuHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean MissionHasColourOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour MissionColourOverride
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Int32 BeginCheckFrequency
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcDefaultMissionItemsTable DefaultItems
	{
		get => GetValue<GcDefaultMissionItemsTable>();
		set => TrySetValue<GcDefaultMissionItemsTable>(value);
	}

	public Boolean PrefixTitle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 NextMissionHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcGenericMissionSequence.MessageCompleteEnum MessageComplete
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.MessageCompleteEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.MessageCompleteEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcGenericMissionSequence.MessageStartEnum MessageStart
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.MessageStartEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.MessageStartEnum>(value);
	}

	public GcMissionBoardOptions MissionBoardOptions
	{
		get => GetValue<GcMissionBoardOptions>();
		set => TrySetValue<GcMissionBoardOptions>(value);
	}

	public libMBIN.NMS.GameComponents.GcGenericMissionSequence.AutoStartEnum AutoStart
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.AutoStartEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGenericMissionSequence.AutoStartEnum>(value);
	}

	public Boolean RestartOnCompletion
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CancelSetsComplete
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAlienPuzzleTable Dialog
	{
		get => GetValue<GcAlienPuzzleTable>();
		set => TrySetValue<GcAlienPuzzleTable>(value);
	}

	public VirtualList<GcScanEventData> ScanEvents
	{
		get => cache.GetOrAddValue(new VirtualList<GcScanEventData>(address + GetOffset()));
		set => TrySetValue<GcScanEventData>(value);
	}

	public VirtualList<GcGenericRewardTableEntry> Rewards
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public VirtualList<GcCostTableEntry> Costs
	{
		get => cache.GetOrAddValue(new VirtualList<GcCostTableEntry>(address + GetOffset()));
		set => TrySetValue<GcCostTableEntry>(value);
	}

	public GcMissionConditionTest StartConditionTest
	{
		get => GetValue<GcMissionConditionTest>();
		set => TrySetValue<GcMissionConditionTest>(value);
	}

	public GcMissionConditionTest CancelConditionTest
	{
		get => GetValue<GcMissionConditionTest>();
		set => TrySetValue<GcMissionConditionTest>(value);
	}

	public Boolean StartIsCancel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSTemplate> StartingConditions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public VirtualList<NMSTemplate> CancelingConditions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public VirtualList<GcGenericMissionVersionProgress> FinalStageVersions
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericMissionVersionProgress>(address + GetOffset()));
		set => TrySetValue<GcGenericMissionVersionProgress>(value);
	}

	public VirtualList<GcGenericMissionStage> Stages
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericMissionStage>(address + GetOffset()));
		set => TrySetValue<GcGenericMissionStage>(value);
	}

	public Boolean ForcesPageHint
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForcesBuildMenuHint
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsProceduralAllowed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsRecurring
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsLegacy
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BlocksPinning
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanRenounce
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 UseCommunityMissionForLog
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean TelemetryUpload
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseSeasonTitleOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcGenericMissionSequence(long address) : base(address)
	{

	}
}
