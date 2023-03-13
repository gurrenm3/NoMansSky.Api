using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterControlInputValidity : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCharacterControlInputValidity.CharacterControlInputValidityEnum CharacterControlInputValidity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCharacterControlInputValidity.CharacterControlInputValidityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCharacterControlInputValidity.CharacterControlInputValidityEnum>(value);
	}

	public GcCharacterControlInputValidity(long address) : base(address)
	{

	}
}
