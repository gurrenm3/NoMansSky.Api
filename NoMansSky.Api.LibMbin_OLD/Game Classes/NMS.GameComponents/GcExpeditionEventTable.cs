using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionEventTable : NMSTemplate
{
	public VirtualList<GcExpeditionEventData> Events
	{
		get => cache.GetOrAddValue(new VirtualList<GcExpeditionEventData>(address + GetOffset()));
		set => TrySetValue<GcExpeditionEventData>(value);
	}

	public VirtualList<GcExpeditionInterventionEventData> InterventionEvents
	{
		get => cache.GetOrAddValue(new VirtualList<GcExpeditionInterventionEventData>(address + GetOffset()));
		set => TrySetValue<GcExpeditionInterventionEventData>(value);
	}

	public GcExpeditionEventTable(long address) : base(address)
	{

	}
}
