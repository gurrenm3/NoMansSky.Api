using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionInventorySlots : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionInventorySlots.InventoryTestEnum InventoryTest
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionInventorySlots.InventoryTestEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionInventorySlots.InventoryTestEnum>(value);
	}

	public Int32 SlotsFree
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public Boolean TestAllSlotsUnlocked
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TestOnlyMainInventory
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionInventorySlots(long address) : base(address)
	{

	}
}
