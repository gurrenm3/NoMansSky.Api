using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyInventoryStackSizeOptionData : NMSTemplate
{
	public Int32 SubstanceStackLimit
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProductStackLimit
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxSubstanceStackSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 12));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxProductStackSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 12));
		set => TrySetValue<Int32>(value);
	}

	public GcDifficultyInventoryStackSizeOptionData(long address) : base(address)
	{

	}
}
