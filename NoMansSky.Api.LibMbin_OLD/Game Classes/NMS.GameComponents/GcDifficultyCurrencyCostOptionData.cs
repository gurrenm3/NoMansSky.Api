using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyCurrencyCostOptionData : NMSTemplate
{
	public VirtualArray<Single> Multipliers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Boolean> FreeCostTypes
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 3));
		set => TrySetValue<Boolean>(value);
	}

	public Single TradeBuyPriceMarkupMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean InteractionsCostsAreFree
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CostManagerCostsAreFree
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDifficultyCurrencyCostOptionData(long address) : base(address)
	{

	}
}
