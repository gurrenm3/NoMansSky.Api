using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetEggTraitModifierOverrideData : NMSTemplate
{
	public NMSString0x10 ProductID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SubstanceID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCreaturePetTraits Trait
	{
		get => GetValue<GcCreaturePetTraits>();
		set => TrySetValue<GcCreaturePetTraits>(value);
	}

	public Boolean IncreasesTrait
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 BaseValueOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPetEggTraitModifierOverrideData(long address) : base(address)
	{

	}
}
