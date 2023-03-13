using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTechnologyAttachmentComponentData : NMSTemplate
{
	public VirtualList<NMSString0x10> Techs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcTechnologyAttachmentComponentData.InventoryEnum Inventory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTechnologyAttachmentComponentData.InventoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTechnologyAttachmentComponentData.InventoryEnum>(value);
	}

	public Boolean Inverted
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcTechnologyAttachmentComponentData(long address) : base(address)
	{

	}
}
