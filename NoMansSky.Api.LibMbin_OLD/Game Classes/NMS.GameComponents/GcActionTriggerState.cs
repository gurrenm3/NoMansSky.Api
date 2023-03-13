using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActionTriggerState : NMSTemplate
{
	public NMSString0x10 StateID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcActionTrigger> Triggers
	{
		get => cache.GetOrAddValue(new VirtualList<GcActionTrigger>(address + GetOffset()));
		set => TrySetValue<GcActionTrigger>(value);
	}

	public GcActionTriggerState(long address) : base(address)
	{

	}
}
