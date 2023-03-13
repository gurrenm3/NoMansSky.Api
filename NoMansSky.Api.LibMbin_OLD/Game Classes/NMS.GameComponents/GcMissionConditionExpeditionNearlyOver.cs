using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionExpeditionNearlyOver : NMSTemplate
{
	public UInt64 RemainingTimeToStartWarning
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcMissionConditionExpeditionNearlyOver(long address) : base(address)
	{

	}
}
