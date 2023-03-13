using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceGroup : NMSTemplate
{
	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcMissionPageHint PageHint
	{
		get => GetValue<GcMissionPageHint>();
		set => TrySetValue<GcMissionPageHint>(value);
	}

	public NMSString0x20A PageDataLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 BuildMenuHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 InventoryHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x20A ObjectiveID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ObjectiveTipID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean HasCategoryOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionCategory OverrideCategory
	{
		get => GetValue<GcMissionCategory>();
		set => TrySetValue<GcMissionCategory>(value);
	}

	public Boolean HasColourOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour ColourOverride
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Boolean PrefixTitle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A PrefixTitleText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean BlockPinning
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionTest ConditionTest
	{
		get => GetValue<GcMissionConditionTest>();
		set => TrySetValue<GcMissionConditionTest>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceGroup.RepeatLogicEnum RepeatLogic
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceGroup.RepeatLogicEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceGroup.RepeatLogicEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceGroup.IconStyleEnum IconStyle
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceGroup.IconStyleEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceGroup.IconStyleEnum>(value);
	}

	public TkInputEnum SpecialButtonIcon
	{
		get => GetValue<TkInputEnum>();
		set => TrySetValue<TkInputEnum>(value);
	}

	public GcObjectiveTextFormatOptions ObjectiveFormatting
	{
		get => GetValue<GcObjectiveTextFormatOptions>();
		set => TrySetValue<GcObjectiveTextFormatOptions>(value);
	}

	public GcTargetMissionSurveyOptions SurveyTarget
	{
		get => GetValue<GcTargetMissionSurveyOptions>();
		set => TrySetValue<GcTargetMissionSurveyOptions>(value);
	}

	public GcCustomNotifyTimerOptions CustomNotifyTimers
	{
		get => GetValue<GcCustomNotifyTimerOptions>();
		set => TrySetValue<GcCustomNotifyTimerOptions>(value);
	}

	public VirtualList<NMSTemplate> Conditions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public VirtualList<NMSTemplate> Consequences
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public VirtualList<GcGenericMissionStage> Stages
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericMissionStage>(address + GetOffset()));
		set => TrySetValue<GcGenericMissionStage>(value);
	}

	public GcMissionSequenceGroup(long address) : base(address)
	{

	}
}
