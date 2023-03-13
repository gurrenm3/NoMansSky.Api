using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcItemPriceModifiers : NMSTemplate
{
	public Single SpaceStationMarkup
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowPriceMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HighPriceMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuyBaseMarkup
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuyMarkupMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcItemPriceModifiers(long address) : base(address)
	{

	}
}
