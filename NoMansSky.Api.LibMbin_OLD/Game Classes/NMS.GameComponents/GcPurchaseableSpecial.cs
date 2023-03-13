using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPurchaseableSpecial : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 ShopNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MissionTier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean IsConsumable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsCape
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPurchaseableSpecial(long address) : base(address)
	{

	}
}
