using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcItemCostData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Cost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChangePerSale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcItemCostData(long address) : base(address)
	{

	}
}
