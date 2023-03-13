using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCharacterStateType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerCharacterStateType.CharacterStateEnum CharacterState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerCharacterStateType.CharacterStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerCharacterStateType.CharacterStateEnum>(value);
	}

	public GcPlayerCharacterStateType(long address) : base(address)
	{

	}
}
