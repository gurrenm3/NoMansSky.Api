using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureNearbyEvent : NMSTemplate
{
	public VirtualList<GcCreatureAlertData> AlertTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureAlertData>(address + GetOffset()));
		set => TrySetValue<GcCreatureAlertData>(value);
	}

	public Boolean Inverse
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureNearbyEvent(long address) : base(address)
	{

	}
}
