using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerOwnershipData : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcResourceElement Resource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcInventoryContainer Inventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer Inventory_Cargo
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer Inventory_TechOnly
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout InventoryLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public UInt64 Location
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Vector4f Position
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f Direction
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public GcPlayerOwnershipData(long address) : base(address)
	{

	}
}
