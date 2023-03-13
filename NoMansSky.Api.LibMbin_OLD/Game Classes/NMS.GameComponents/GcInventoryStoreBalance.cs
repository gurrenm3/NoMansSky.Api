using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryStoreBalance : NMSTemplate
{
	public Int32 PlayerPersonalInventoryTechWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PlayerPersonalInventoryTechHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PlayerPersonalInventoryCargoWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PlayerPersonalInventoryCargoHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DeconstructRefundPercentage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcInventoryStoreBalance(long address) : base(address)
	{

	}
}
