using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetTraitMoodModifierList : NMSTemplate
{
	public VirtualArray<GcPetTraitMoodModifier> Modifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetTraitMoodModifier>(address + GetOffset(), 2));
		set => TrySetValue<GcPetTraitMoodModifier>(value);
	}

	public GcPetTraitMoodModifierList(long address) : base(address)
	{

	}
}
