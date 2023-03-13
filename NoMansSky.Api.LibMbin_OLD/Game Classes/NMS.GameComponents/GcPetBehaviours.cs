using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetBehaviours : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPetBehaviours.PetBehaviourEnum PetBehaviour
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPetBehaviours.PetBehaviourEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPetBehaviours.PetBehaviourEnum>(value);
	}

	public GcPetBehaviours(long address) : base(address)
	{

	}
}
