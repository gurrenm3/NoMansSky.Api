using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardPoliceScanSignal : NMSTemplate
{
	public Boolean Attack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardPoliceScanSignal(long address) : base(address)
	{

	}
}
