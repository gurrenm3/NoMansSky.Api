using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageRequestTakeOff : NMSTemplate
{
	public Single Delay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ImmediatelyDissolveNPC
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMessageRequestTakeOff(long address) : base(address)
	{

	}
}
