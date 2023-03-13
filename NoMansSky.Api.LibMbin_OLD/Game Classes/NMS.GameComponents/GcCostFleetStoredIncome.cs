using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostFleetStoredIncome : NMSTemplate
{
	public GcFrigateClass Class
	{
		get => GetValue<GcFrigateClass>();
		set => TrySetValue<GcFrigateClass>(value);
	}

	public Int32 RequiredAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostFleetStoredIncome(long address) : base(address)
	{

	}
}
