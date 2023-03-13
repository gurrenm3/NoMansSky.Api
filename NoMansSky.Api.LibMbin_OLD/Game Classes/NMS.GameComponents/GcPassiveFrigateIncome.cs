using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPassiveFrigateIncome : NMSTemplate
{
	public NMSString0x10 IncomeId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcInventoryType IncomeType
	{
		get => GetValue<GcInventoryType>();
		set => TrySetValue<GcInventoryType>(value);
	}

	public Int32 AmountOfIncomeRewarded
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ForEveryXAmountOfTheStat
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPassiveFrigateIncome(long address) : base(address)
	{

	}
}
