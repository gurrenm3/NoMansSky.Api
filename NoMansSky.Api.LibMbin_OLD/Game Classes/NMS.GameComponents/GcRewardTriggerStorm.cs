using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTriggerStorm : NMSTemplate
{
	public Single Duration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRewardTriggerStorm(long address) : base(address)
	{

	}
}
