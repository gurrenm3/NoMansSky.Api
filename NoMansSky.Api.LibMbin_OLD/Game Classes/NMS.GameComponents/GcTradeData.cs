using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTradeData : NMSTemplate
{
	public VirtualList<NMSString0x10> AlwaysPresentProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> AlwaysPresentSubstances
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> OptionalProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> OptionalSubstances
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MinItemsForSale
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxItemsForSale
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PercentageOfItemsAreProducts
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuyPriceIncreaseRedThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuyPriceDecreaseGreenThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SellPriceIncreaseGreenThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SellPriceDecreaseRedThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowSeasonRewards
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Int32> MinAmountOfProductAvailable
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxAmountOfProductAvailable
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MinAmountOfSubstanceAvailable
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxAmountOfSubstanceAvailable
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MinExtraSystemProducts
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxExtraSystemProducts
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Single> TradeProductsPriceImprovements
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public GcTradeData(long address) : base(address)
	{

	}
}
