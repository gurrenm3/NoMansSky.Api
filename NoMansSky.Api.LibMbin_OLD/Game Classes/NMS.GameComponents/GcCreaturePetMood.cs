using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetMood : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreaturePetMood.PetMoodEnum PetMood
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreaturePetMood.PetMoodEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreaturePetMood.PetMoodEnum>(value);
	}

	public GcCreaturePetMood(long address) : base(address)
	{

	}
}
