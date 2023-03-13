using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActionUseType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcActionUseType.ActionUseTypeEnum ActionUseType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcActionUseType.ActionUseTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcActionUseType.ActionUseTypeEnum>(value);
	}

	public GcActionUseType(long address) : base(address)
	{

	}
}
