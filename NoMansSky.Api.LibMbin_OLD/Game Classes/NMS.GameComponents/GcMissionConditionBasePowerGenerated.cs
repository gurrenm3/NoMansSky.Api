using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionBasePowerGenerated : NMSTemplate
{
	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean MustBeSpare
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TakeAmountFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionBasePowerGenerated(long address) : base(address)
	{

	}
}
