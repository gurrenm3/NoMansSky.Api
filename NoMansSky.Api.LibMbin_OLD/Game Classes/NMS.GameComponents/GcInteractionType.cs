using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInteractionType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInteractionType.InteractionTypeEnum InteractionType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInteractionType.InteractionTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInteractionType.InteractionTypeEnum>(value);
	}

	public GcInteractionType(long address) : base(address)
	{

	}
}
