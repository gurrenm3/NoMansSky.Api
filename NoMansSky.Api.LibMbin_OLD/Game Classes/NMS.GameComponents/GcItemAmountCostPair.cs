using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcItemAmountCostPair : NMSTemplate
{
	public NMSString0x10 ItemId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcItemAmountCostPair(long address) : base(address)
	{

	}
}
