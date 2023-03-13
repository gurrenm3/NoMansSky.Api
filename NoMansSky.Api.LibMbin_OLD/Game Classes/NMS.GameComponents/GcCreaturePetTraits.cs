using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetTraits : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreaturePetTraits.PetTraitEnum PetTrait
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreaturePetTraits.PetTraitEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreaturePetTraits.PetTraitEnum>(value);
	}

	public GcCreaturePetTraits(long address) : base(address)
	{

	}
}
