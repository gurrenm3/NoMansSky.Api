using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetTraitMoodModifier : NMSTemplate
{
	public Single TraitMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraitMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoodIncreaseMultiplierMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoodIncreaseMultiplierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPetTraitMoodModifier(long address) : base(address)
	{

	}
}
