using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPuzzleTextFlow : NMSTemplate
{
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

	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAlienMood Mood
	{
		get => GetValue<GcAlienMood>();
		set => TrySetValue<GcAlienMood>(value);
	}

	public libMBIN.NMS.GameComponents.GcPuzzleTextFlow.TranslateAlienTextOverrideEnum TranslateAlienTextOverride
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPuzzleTextFlow.TranslateAlienTextOverrideEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPuzzleTextFlow.TranslateAlienTextOverrideEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcPuzzleTextFlow.BracketsOverrideEnum BracketsOverride
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPuzzleTextFlow.BracketsOverrideEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPuzzleTextFlow.BracketsOverrideEnum>(value);
	}

	public GcAudioWwiseEvents AudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcPuzzleTextFlow(long address) : base(address)
	{

	}
}
