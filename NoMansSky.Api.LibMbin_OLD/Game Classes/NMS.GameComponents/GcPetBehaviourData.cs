using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetBehaviourData : NMSTemplate
{
	public Boolean ReactiveBehaviour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsefulBehaviour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPerformTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPerformTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CooldownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChatChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ApproachPlayerDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SearchDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcPetBehaviourData.PetBehaviourValidityEnum PetBehaviourValidity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPetBehaviourData.PetBehaviourValidityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPetBehaviourData.PetBehaviourValidityEnum>(value);
	}

	public VirtualList<GcPetFollowUpBehaviour> FollowUpBehaviours
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetFollowUpBehaviour>(address + GetOffset()));
		set => TrySetValue<GcPetFollowUpBehaviour>(value);
	}

	public VirtualList<GcPetBehaviourTraitModifier> TraitBehaviourModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetBehaviourTraitModifier>(address + GetOffset()));
		set => TrySetValue<GcPetBehaviourTraitModifier>(value);
	}

	public VirtualList<GcPetBehaviourMoodModifier> MoodBehaviourModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetBehaviourMoodModifier>(address + GetOffset()));
		set => TrySetValue<GcPetBehaviourMoodModifier>(value);
	}

	public VirtualArray<Single> MoodModifyOnComplete
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 2));
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A LabelText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPetBehaviourData(long address) : base(address)
	{

	}
}
