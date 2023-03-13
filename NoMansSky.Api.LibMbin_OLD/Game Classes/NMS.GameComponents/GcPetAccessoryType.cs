using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetAccessoryType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPetAccessoryType.PetAccessoryEnum PetAccessory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPetAccessoryType.PetAccessoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPetAccessoryType.PetAccessoryEnum>(value);
	}

	public GcPetAccessoryType(long address) : base(address)
	{

	}
}
