using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardPetAction : NMSTemplate
{
	public GcCreaturePetRewardActions PetAction
	{
		get => GetValue<GcCreaturePetRewardActions>();
		set => TrySetValue<GcCreaturePetRewardActions>(value);
	}

	public NMSString0x10 PlayerEmoteID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 EffectID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SpecialHarvestID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 SpecialHarvestMul
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRewardPetAction(long address) : base(address)
	{

	}
}
