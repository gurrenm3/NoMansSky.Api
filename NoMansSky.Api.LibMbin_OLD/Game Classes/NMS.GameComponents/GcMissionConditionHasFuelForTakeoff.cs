using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasFuelForTakeoff : NMSTemplate
{
	public Boolean FormatTextAsPercentage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasFuelForTakeoff(long address) : base(address)
	{

	}
}
