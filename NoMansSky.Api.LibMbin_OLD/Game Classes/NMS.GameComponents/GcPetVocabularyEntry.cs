using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetVocabularyEntry : NMSTemplate
{
	public NMSString0x20A GenericFallback
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single OddsOfProcReplacement
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcPetVocabularyTraitEntry> Vocabulary
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetVocabularyTraitEntry>(address + GetOffset()));
		set => TrySetValue<GcPetVocabularyTraitEntry>(value);
	}

	public GcPetVocabularyEntry(long address) : base(address)
	{

	}
}
