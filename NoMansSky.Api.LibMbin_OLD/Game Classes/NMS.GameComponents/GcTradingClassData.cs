using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTradingClassData : NMSTemplate
{
	public GcTradeCategory Sells
	{
		get => GetValue<GcTradeCategory>();
		set => TrySetValue<GcTradeCategory>(value);
	}

	public GcTradeCategory Needs
	{
		get => GetValue<GcTradeCategory>();
		set => TrySetValue<GcTradeCategory>(value);
	}

	public Single MinSellingPriceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSellingPriceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinBuyingPriceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxBuyingPriceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcTradingClassData(long address) : base(address)
	{

	}
}
