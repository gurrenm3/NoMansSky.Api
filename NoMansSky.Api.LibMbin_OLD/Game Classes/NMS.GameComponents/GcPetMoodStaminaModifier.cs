using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetMoodStaminaModifier : NMSTemplate
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

	public Single StaminaDrainModifierMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StaminaDrainModifierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StaminaRechargeModifierMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StaminaRechargeModifierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPetMoodStaminaModifier(long address) : base(address)
	{

	}
}
