using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostItemListIndexed : NMSTemplate
{
	public VirtualList<NMSString0x10> Costs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean AssertIfOutOfBounds
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcCostItemListIndexed.ItemOutOfBoundsBehaviourEnum ItemOutOfBoundsBehaviour
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCostItemListIndexed.ItemOutOfBoundsBehaviourEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCostItemListIndexed.ItemOutOfBoundsBehaviourEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcCostItemListIndexed.ItemIndexProviderEnum ItemIndexProvider
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCostItemListIndexed.ItemIndexProviderEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCostItemListIndexed.ItemIndexProviderEnum>(value);
	}

	public GcCostItemListIndexed(long address) : base(address)
	{

	}
}
