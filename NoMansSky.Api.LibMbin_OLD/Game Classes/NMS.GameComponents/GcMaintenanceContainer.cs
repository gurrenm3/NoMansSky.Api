using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMaintenanceContainer : NMSTemplate
{
	public GcInventoryContainer InventoryContainer
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public UInt64 LastUpdateTimestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 LastCompletedTimestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 LastBrokenTimestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<Single> DamageTimers
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> AmountAccumulators
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public UInt16 Flags
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public GcMaintenanceContainer(long address) : base(address)
	{

	}
}
