using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardDestructEntry : NMSTemplate
{
	public Single HealthFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRewardDestructEntry(long address) : base(address)
	{

	}
}
