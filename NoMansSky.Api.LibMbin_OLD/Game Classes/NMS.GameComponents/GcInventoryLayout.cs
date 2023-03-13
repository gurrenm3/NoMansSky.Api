using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryLayout : NMSTemplate
{
	public Int32 Slots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Int32 Level
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryLayout(long address) : base(address)
	{

	}
}
