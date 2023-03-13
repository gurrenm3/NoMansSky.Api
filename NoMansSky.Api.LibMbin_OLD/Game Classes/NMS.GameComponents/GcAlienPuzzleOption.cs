using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienPuzzleOption : NMSTemplate
{
	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Text
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean IsAlien
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 Cost
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> Rewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcAlienMood Mood
	{
		get => GetValue<GcAlienMood>();
		set => TrySetValue<GcAlienMood>(value);
	}

	public GcNPCPropType Prop
	{
		get => GetValue<GcNPCPropType>();
		set => TrySetValue<GcNPCPropType>(value);
	}

	public Boolean OverrideWithAlienWord
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ReseedInteractionOnUse
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean KeepOpen
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisplayCost
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TruncateCost
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MarkInteractionComplete
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A NextInteraction
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean SelectedOnBackOut
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAudioWwiseEvents AudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public NMSString0x20A TitleOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcMissionConditionTest EnablingConditionTest
	{
		get => GetValue<GcMissionConditionTest>();
		set => TrySetValue<GcMissionConditionTest>(value);
	}

	public VirtualList<NMSTemplate> EnablingConditions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public NMSString0x20A EnablingConditionId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcWordCategoryTableEnum WordCategory
	{
		get => GetValue<GcWordCategoryTableEnum>();
		set => TrySetValue<GcWordCategoryTableEnum>(value);
	}

	public GcAlienPuzzleOption(long address) : base(address)
	{

	}
}
