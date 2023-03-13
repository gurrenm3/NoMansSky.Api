using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeaponInventoryMaxUpgradeCapacity : NMSTemplate
{
	public VirtualArray<Int32> MaxInventoryCapacity
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public GcWeaponInventoryMaxUpgradeCapacity(long address) : base(address)
	{

	}
}
