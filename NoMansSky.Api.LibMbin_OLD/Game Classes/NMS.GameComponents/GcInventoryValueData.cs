using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryValueData : NMSTemplate
{
	public Single BaseMinValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseMaxValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExponentialValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseCostPerSlot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlotExponentialValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ValueToCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlotsPerLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcInventoryValueData(long address) : base(address)
	{

	}
}
