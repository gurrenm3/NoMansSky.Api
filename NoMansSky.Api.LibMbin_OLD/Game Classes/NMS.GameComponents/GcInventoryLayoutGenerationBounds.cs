using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryLayoutGenerationBounds : NMSTemplate
{
	public Int32 MaxWidthSmall
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxHeightSmall
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxWidthStandard
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxHeightStandard
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxWidthLarge
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxHeightLarge
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryLayoutGenerationBounds(long address) : base(address)
	{

	}
}
