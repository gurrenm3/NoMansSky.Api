using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasMoney : NMSTemplate
{
	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCurrency TestCurrency
	{
		get => GetValue<GcCurrency>();
		set => TrySetValue<GcCurrency>(value);
	}

	public Boolean ApplyDifficultyScaling
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasMoney(long address) : base(address)
	{

	}
}
