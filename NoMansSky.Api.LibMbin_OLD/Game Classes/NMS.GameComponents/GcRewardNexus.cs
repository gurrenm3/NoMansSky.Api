using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardNexus : NMSTemplate
{
	public Boolean Allow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardNexus(long address) : base(address)
	{

	}
}
