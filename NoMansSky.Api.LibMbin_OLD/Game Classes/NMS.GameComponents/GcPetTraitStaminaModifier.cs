using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetTraitStaminaModifier : NMSTemplate
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

	public GcPetTraitStaminaModifier(long address) : base(address)
	{

	}
}
