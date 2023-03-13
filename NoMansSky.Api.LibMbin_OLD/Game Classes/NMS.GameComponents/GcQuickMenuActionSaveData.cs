using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcQuickMenuActionSaveData : NMSTemplate
{
	public GcQuickMenuActions Action
	{
		get => GetValue<GcQuickMenuActions>();
		set => TrySetValue<GcQuickMenuActions>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Number
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryIndex InventoryIndex
	{
		get => GetValue<GcInventoryIndex>();
		set => TrySetValue<GcInventoryIndex>(value);
	}

	public GcQuickMenuActionSaveData(long address) : base(address)
	{

	}
}
