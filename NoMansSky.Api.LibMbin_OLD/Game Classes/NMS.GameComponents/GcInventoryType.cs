using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInventoryType.InventoryTypeEnum InventoryType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventoryType.InventoryTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventoryType.InventoryTypeEnum>(value);
	}

	public GcInventoryType(long address) : base(address)
	{

	}
}
