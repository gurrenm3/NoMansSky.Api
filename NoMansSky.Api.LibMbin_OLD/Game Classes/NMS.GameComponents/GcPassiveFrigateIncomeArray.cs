using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPassiveFrigateIncomeArray : NMSTemplate
{
	public VirtualArray<GcPassiveFrigateIncome> Array
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPassiveFrigateIncome>(address + GetOffset(), 8));
		set => TrySetValue<GcPassiveFrigateIncome>(value);
	}

	public GcPassiveFrigateIncomeArray(long address) : base(address)
	{

	}
}
