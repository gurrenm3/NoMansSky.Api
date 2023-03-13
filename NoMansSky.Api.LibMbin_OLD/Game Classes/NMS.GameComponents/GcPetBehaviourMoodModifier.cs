using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetBehaviourMoodModifier : NMSTemplate
{
	public GcCreaturePetMood Mood
	{
		get => GetValue<GcCreaturePetMood>();
		set => TrySetValue<GcCreaturePetMood>(value);
	}

	public Single MoodMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoodMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeightModifierMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeightModifierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CooldownModifierMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CooldownModifierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPetBehaviourMoodModifier(long address) : base(address)
	{

	}
}
