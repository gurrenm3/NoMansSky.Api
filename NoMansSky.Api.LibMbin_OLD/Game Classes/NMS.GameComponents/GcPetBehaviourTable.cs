using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetBehaviourTable : NMSTemplate
{
	public VirtualArray<GcPetBehaviourData> Behaviours
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetBehaviourData>(address + GetOffset(), 28));
		set => TrySetValue<GcPetBehaviourData>(value);
	}

	public Single GlobalCooldownModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UsefulBehaviourLinkedCooldownAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerActivityIncreaseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerActivityDecreaseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> MoodIncreaseTime
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 2));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<GcPetTraitMoodModifierList> TraitMoodModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetTraitMoodModifierList>(address + GetOffset(), 3));
		set => TrySetValue<GcPetTraitMoodModifierList>(value);
	}

	public VirtualArray<GcPetActionMoodModifier> RewardMoodModifier
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetActionMoodModifier>(address + GetOffset(), 9));
		set => TrySetValue<GcPetActionMoodModifier>(value);
	}

	public VirtualArray<GcCreaturePetTraitRanges> TraitRanges
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCreaturePetTraitRanges>(address + GetOffset(), 11));
		set => TrySetValue<GcCreaturePetTraitRanges>(value);
	}

	public VirtualArray<Single> MoodValuesOnAdopt
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 2));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> MoodValuesOnHatch
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 2));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcPetTraitStaminaModifier> TraitStaminaModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetTraitStaminaModifier>(address + GetOffset()));
		set => TrySetValue<GcPetTraitStaminaModifier>(value);
	}

	public VirtualList<GcPetMoodStaminaModifier> MoodStaminaModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetMoodStaminaModifier>(address + GetOffset()));
		set => TrySetValue<GcPetMoodStaminaModifier>(value);
	}

	public Single AccessoryGyroFollowMotionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AccessoryGyroToNeutralStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AccessoryGyroDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AccessoryGyroStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AccessoryGyroActive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPetBehaviourTable(long address) : base(address)
	{

	}
}
