using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionAlienPodAggroed : NMSTemplate
{
	public Single Threshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionConditionAlienPodAggroed(long address) : base(address)
	{

	}
}
