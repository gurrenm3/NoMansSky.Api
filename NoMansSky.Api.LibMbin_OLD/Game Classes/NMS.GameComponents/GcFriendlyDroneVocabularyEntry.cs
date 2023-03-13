using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFriendlyDroneVocabularyEntry : NMSTemplate
{
	public NMSString0x20A GenericFallback
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcFriendlyDroneVocabularyEntry(long address) : base(address)
	{

	}
}
