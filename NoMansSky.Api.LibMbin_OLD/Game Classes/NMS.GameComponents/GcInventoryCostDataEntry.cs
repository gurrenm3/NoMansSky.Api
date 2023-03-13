using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryCostDataEntry : NMSTemplate
{
	public Int32 MinSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MinValueInMillions
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MaxValueInMillions
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoolMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeInMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> ClassMultiplier
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public GcInventoryCostDataEntry(long address) : base(address)
	{

	}
}
