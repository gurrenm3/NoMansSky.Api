using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienMood : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAlienMood.MoodEnum Mood
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAlienMood.MoodEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAlienMood.MoodEnum>(value);
	}

	public GcAlienMood(long address) : base(address)
	{

	}
}
