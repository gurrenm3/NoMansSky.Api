using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpecialPetChatType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSpecialPetChatType.SpecialPetChatTypeEnum SpecialPetChatType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpecialPetChatType.SpecialPetChatTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpecialPetChatType.SpecialPetChatTypeEnum>(value);
	}

	public GcSpecialPetChatType(long address) : base(address)
	{

	}
}
