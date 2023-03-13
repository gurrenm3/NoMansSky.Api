using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTriggerFeedbackStateTable : NMSTemplate
{
	public VirtualList<GcTriggerFeedbackState> Events
	{
		get => cache.GetOrAddValue(new VirtualList<GcTriggerFeedbackState>(address + GetOffset()));
		set => TrySetValue<GcTriggerFeedbackState>(value);
	}

	public GcTriggerFeedbackStateTable(long address) : base(address)
	{

	}
}
