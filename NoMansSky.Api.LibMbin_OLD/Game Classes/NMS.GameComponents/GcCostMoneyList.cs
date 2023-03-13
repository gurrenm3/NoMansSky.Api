using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostMoneyList : NMSTemplate
{
	public VirtualList<Int32> Costs
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public GcCurrency CostCurrency
	{
		get => GetValue<GcCurrency>();
		set => TrySetValue<GcCurrency>(value);
	}

	public Boolean AssertIfOutOfBounds
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcCostMoneyList.OutOfBoundsBehaviourEnum OutOfBoundsBehaviour
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCostMoneyList.OutOfBoundsBehaviourEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCostMoneyList.OutOfBoundsBehaviourEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcCostMoneyList.IndexProviderEnum IndexProvider
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCostMoneyList.IndexProviderEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCostMoneyList.IndexProviderEnum>(value);
	}

	public GcCostMoneyList(long address) : base(address)
	{

	}
}
