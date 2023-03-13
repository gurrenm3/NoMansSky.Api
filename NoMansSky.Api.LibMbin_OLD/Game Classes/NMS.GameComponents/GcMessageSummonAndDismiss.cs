using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageSummonAndDismiss : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMessageSummonAndDismiss.SummonEventTypeEnum SummonEventType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMessageSummonAndDismiss.SummonEventTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMessageSummonAndDismiss.SummonEventTypeEnum>(value);
	}

	public GcMessageSummonAndDismiss(long address) : base(address)
	{

	}
}
