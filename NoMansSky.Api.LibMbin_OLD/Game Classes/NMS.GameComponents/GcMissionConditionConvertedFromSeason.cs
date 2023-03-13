using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionConvertedFromSeason : NMSTemplate
{
	public Int32 Season
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionConvertedFromSeason(long address) : base(address)
	{

	}
}
