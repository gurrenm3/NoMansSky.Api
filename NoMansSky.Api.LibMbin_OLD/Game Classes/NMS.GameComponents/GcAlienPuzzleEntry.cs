using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienPuzzleEntry : NMSTemplate
{
	public Int32 ProgressionIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinProgressionForSelection
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A Id
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public GcInteractionType Type
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public GcAlienPuzzleCategory Category
	{
		get => GetValue<GcAlienPuzzleCategory>();
		set => TrySetValue<GcAlienPuzzleCategory>(value);
	}

	public libMBIN.NMS.GameComponents.GcAlienPuzzleEntry.AdditionalOptionsEnum AdditionalOptions
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleEntry.AdditionalOptionsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleEntry.AdditionalOptionsEnum>(value);
	}

	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Text
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TextAlien
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean TranslateAlienText
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TranslationBrackets
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ProgressiveDialogue
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A RequiresScanEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcAlienPuzzleOption> Options
	{
		get => cache.GetOrAddValue(new VirtualList<GcAlienPuzzleOption>(address + GetOffset()));
		set => TrySetValue<GcAlienPuzzleOption>(value);
	}

	public VirtualList<NMSString0x20A> AdditionalText
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<NMSString0x20A> AdditionalTextAlien
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
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

	public VirtualList<GcPuzzleTextFlow> AdvancedInteractionFlow
	{
		get => cache.GetOrAddValue(new VirtualList<GcPuzzleTextFlow>(address + GetOffset()));
		set => TrySetValue<GcPuzzleTextFlow>(value);
	}

	public libMBIN.NMS.GameComponents.GcAlienPuzzleEntry.PersistancyBufferOverrideEnum PersistancyBufferOverride
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleEntry.PersistancyBufferOverrideEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleEntry.PersistancyBufferOverrideEnum>(value);
	}

	public Int32 CustomFreighterTextIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean RadialInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAudioWwiseEvents NextStageAudioEventOverride
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAlienPuzzleEntry(long address) : base(address)
	{

	}
}
