using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryClass : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInventoryClass.InventoryClassEnum InventoryClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventoryClass.InventoryClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventoryClass.InventoryClassEnum>(value);
	}

	public GcInventoryClass(long address) : base(address)
	{

	}
}
