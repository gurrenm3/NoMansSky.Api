using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkTriggerFeedbackData : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkTriggerFeedbackData.FeedbackTypeEnum FeedbackType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkTriggerFeedbackData.FeedbackTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkTriggerFeedbackData.FeedbackTypeEnum>(value);
	}

	public Single Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Position
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Frequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkTriggerFeedbackData(long address) : base(address)
	{

	}
}
