using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetChatType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPetChatType.PetChatTypeEnum PetChatType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPetChatType.PetChatTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPetChatType.PetChatTypeEnum>(value);
	}

	public GcPetChatType(long address) : base(address)
	{

	}
}
