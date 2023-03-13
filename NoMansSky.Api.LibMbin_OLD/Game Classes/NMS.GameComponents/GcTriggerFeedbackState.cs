using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTriggerFeedbackState : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcInputActions Action
	{
		get => GetValue<GcInputActions>();
		set => TrySetValue<GcInputActions>(value);
	}

	public TkTriggerFeedbackData Data
	{
		get => GetValue<TkTriggerFeedbackData>();
		set => TrySetValue<TkTriggerFeedbackData>(value);
	}

	public GcTriggerFeedbackState(long address) : base(address)
	{

	}
}
