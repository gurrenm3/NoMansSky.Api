using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionUnderwaterDepth : NMSTemplate
{
	public Single Depth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TakeAmountFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionUnderwaterDepth(long address) : base(address)
	{

	}
}
