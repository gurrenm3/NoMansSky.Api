using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterControlOutputSpace : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCharacterControlOutputSpace.CharacterControlOutputSpaceEnum CharacterControlOutputSpace
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCharacterControlOutputSpace.CharacterControlOutputSpaceEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCharacterControlOutputSpace.CharacterControlOutputSpaceEnum>(value);
	}

	public GcCharacterControlOutputSpace(long address) : base(address)
	{

	}
}
