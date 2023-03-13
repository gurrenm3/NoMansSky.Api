using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostMoney : NMSTemplate
{
	public Int32 Cost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCurrency CostCurrency
	{
		get => GetValue<GcCurrency>();
		set => TrySetValue<GcCurrency>(value);
	}

	public GcCostMoney(long address) : base(address)
	{

	}
}
