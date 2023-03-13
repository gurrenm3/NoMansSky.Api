using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStateTimeEvent : NMSTemplate
{
	public Single Seconds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RandomSeconds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseMissionClock
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcStateTimeEvent(long address) : base(address)
	{

	}
}
