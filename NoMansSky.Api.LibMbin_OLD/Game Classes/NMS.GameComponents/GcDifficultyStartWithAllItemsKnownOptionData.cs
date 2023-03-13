using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyStartWithAllItemsKnownOptionData : NMSTemplate
{
	public GcKnownThingsPreset InitialKnownThings
	{
		get => GetValue<GcKnownThingsPreset>();
		set => TrySetValue<GcKnownThingsPreset>(value);
	}

	public GcInventoryContainer InitialShipInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryContainer InitialWeaponInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcDifficultyStartWithAllItemsKnownOptionData(long address) : base(address)
	{

	}
}
