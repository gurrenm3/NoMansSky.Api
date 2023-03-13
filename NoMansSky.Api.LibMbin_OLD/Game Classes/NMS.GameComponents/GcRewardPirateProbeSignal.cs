using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardPirateProbeSignal : NMSTemplate
{
	public Boolean Attack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardPirateProbeSignal(long address) : base(address)
	{

	}
}
