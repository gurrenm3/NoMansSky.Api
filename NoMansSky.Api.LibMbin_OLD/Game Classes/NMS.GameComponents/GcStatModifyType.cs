using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatModifyType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatModifyType.ModifyTypeEnum ModifyType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatModifyType.ModifyTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatModifyType.ModifyTypeEnum>(value);
	}

	public GcStatModifyType(long address) : base(address)
	{

	}
}
