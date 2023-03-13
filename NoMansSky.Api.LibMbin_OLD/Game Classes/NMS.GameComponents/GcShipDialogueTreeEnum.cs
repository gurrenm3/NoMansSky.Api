using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipDialogueTreeEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcShipDialogueTreeEnum.DialogueTreeEnum DialogueTree
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcShipDialogueTreeEnum.DialogueTreeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcShipDialogueTreeEnum.DialogueTreeEnum>(value);
	}

	public GcShipDialogueTreeEnum(long address) : base(address)
	{

	}
}
