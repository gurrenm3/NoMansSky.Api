using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetVocabularyTraitEntry : NMSTemplate
{
	public GcCreaturePetTraits Trait
	{
		get => GetValue<GcCreaturePetTraits>();
		set => TrySetValue<GcCreaturePetTraits>(value);
	}

	public NMSString0x20A Positive
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Negative
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPetVocabularyTraitEntry(long address) : base(address)
	{

	}
}
