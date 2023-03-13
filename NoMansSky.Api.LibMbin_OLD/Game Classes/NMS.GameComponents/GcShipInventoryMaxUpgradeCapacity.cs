using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipInventoryMaxUpgradeCapacity : NMSTemplate
{
	public VirtualArray<Int32> MaxInventoryCapacity
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxTechInventoryCapacity
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxCargoInventoryCapacity
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public GcShipInventoryMaxUpgradeCapacity(long address) : base(address)
	{

	}
}
