using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStormEvent : NMSTemplate
{
	public Boolean InStorm
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcStormEvent(long address) : base(address)
	{

	}
}
