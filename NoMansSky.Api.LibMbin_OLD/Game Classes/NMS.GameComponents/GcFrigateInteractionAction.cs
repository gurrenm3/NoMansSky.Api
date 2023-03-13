using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateInteractionAction : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFrigateInteractionAction.ActionTypeEnum ActionType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFrigateInteractionAction.ActionTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFrigateInteractionAction.ActionTypeEnum>(value);
	}

	public NMSString0x20A CommunicatorDialog
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcFrigateInteractionAction(long address) : base(address)
	{

	}
}
