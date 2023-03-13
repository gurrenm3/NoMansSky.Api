using Reloaded.ModHelper;
using System;
using libMBIN;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActionTrigger : NMSTemplate
{
	public NMSTemplate Event
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public VirtualList<NMSTemplate> Action
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcActionTrigger(long address) : base(address)
	{

	}
}
