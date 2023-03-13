using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionTotalWarpsNumber : NMSTemplate
{
	public Int32 WarpsNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionTotalWarpsNumber(long address) : base(address)
	{

	}
}
