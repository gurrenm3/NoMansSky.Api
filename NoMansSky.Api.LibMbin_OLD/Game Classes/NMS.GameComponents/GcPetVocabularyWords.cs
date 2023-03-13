using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetVocabularyWords : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPetVocabularyWords.PetVocabularyWordEnum PetVocabularyWord
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPetVocabularyWords.PetVocabularyWordEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPetVocabularyWords.PetVocabularyWordEnum>(value);
	}

	public GcPetVocabularyWords(long address) : base(address)
	{

	}
}
