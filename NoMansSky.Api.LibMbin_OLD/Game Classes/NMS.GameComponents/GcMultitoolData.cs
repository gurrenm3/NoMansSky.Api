using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMultitoolData : NMSTemplate
{
	public GcInventoryLayout Layout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer Store
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean IsLarge
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 PrimaryMode
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SecondaryMode
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseLegacyColours
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcResourceElement Resource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcMultitoolData(long address) : base(address)
	{

	}
}
