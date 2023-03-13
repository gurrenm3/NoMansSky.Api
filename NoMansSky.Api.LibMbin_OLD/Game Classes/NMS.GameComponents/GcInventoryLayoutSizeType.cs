using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryLayoutSizeType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInventoryLayoutSizeType.SizeTypeEnum SizeType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventoryLayoutSizeType.SizeTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventoryLayoutSizeType.SizeTypeEnum>(value);
	}

	public GcInventoryLayoutSizeType(long address) : base(address)
	{

	}
}
