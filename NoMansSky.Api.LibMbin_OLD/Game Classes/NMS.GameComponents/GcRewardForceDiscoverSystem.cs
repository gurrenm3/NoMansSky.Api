using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardForceDiscoverSystem : NMSTemplate
{
	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardForceDiscoverSystem(long address) : base(address)
	{

	}
}
