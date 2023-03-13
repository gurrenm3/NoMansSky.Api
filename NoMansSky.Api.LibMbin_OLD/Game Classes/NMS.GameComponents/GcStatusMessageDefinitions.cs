using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatusMessageDefinitions : NMSTemplate
{
	public VirtualList<GcStatusMessageDefinition> Messages
	{
		get => cache.GetOrAddValue(new VirtualList<GcStatusMessageDefinition>(address + GetOffset()));
		set => TrySetValue<GcStatusMessageDefinition>(value);
	}

	public Colour MissionMarkupColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<GcPetVocabularyEntry> PetVocabulary
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetVocabularyEntry>(address + GetOffset(), 15));
		set => TrySetValue<GcPetVocabularyEntry>(value);
	}

	public VirtualArray<GcPetVocabularyEntry> PetChatTemplates
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetVocabularyEntry>(address + GetOffset(), 21));
		set => TrySetValue<GcPetVocabularyEntry>(value);
	}

	public VirtualArray<GcFriendlyDroneVocabularyEntry> FriendlyDroneChatTemplates
	{
		get => cache.GetOrAddValue(new VirtualArray<GcFriendlyDroneVocabularyEntry>(address + GetOffset(), 5));
		set => TrySetValue<GcFriendlyDroneVocabularyEntry>(value);
	}

	public GcStatusMessageDefinitions(long address) : base(address)
	{

	}
}
