using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienSpeechEntry : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Text
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Group
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcWordCategoryTableEnum Category
	{
		get => GetValue<GcWordCategoryTableEnum>();
		set => TrySetValue<GcWordCategoryTableEnum>(value);
	}

	public Int32 Frequency
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcAlienSpeechEntry.WordInteractEffectEnum WordInteractEffect
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAlienSpeechEntry.WordInteractEffectEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAlienSpeechEntry.WordInteractEffectEnum>(value);
	}

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Int32 Level
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcAlienSpeechEntry(long address) : base(address)
	{

	}
}
