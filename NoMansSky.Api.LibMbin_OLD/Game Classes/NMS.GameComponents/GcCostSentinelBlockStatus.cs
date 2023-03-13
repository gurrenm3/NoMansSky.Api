using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostSentinelBlockStatus : NMSTemplate
{
	public Boolean CanAffordIfSentinelsDisabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCostSentinelBlockStatus(long address) : base(address)
	{

	}
}
