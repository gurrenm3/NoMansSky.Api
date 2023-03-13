using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostAdvanceSettlementBuilding : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostAdvanceSettlementBuilding(long address) : base(address)
	{

	}
}
