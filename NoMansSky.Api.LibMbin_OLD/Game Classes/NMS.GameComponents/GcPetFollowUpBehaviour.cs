using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetFollowUpBehaviour : NMSTemplate
{
	public GcPetBehaviours Behaviour
	{
		get => GetValue<GcPetBehaviours>();
		set => TrySetValue<GcPetBehaviours>(value);
	}

	public Boolean TraitBased
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

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

	public Single WeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPetFollowUpBehaviour(long address) : base(address)
	{

	}
}
