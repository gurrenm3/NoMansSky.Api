using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetBehaviourTraitModifier : NMSTemplate
{
	public GcCreaturePetTraits Trait
	{
		get => GetValue<GcCreaturePetTraits>();
		set => TrySetValue<GcCreaturePetTraits>(value);
	}

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

	public GcPetBehaviourTraitModifier(long address) : base(address)
	{

	}
}
