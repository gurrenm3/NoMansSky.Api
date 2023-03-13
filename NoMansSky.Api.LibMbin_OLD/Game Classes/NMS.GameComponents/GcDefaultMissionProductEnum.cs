using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDefaultMissionProductEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDefaultMissionProductEnum.DefaultProductTypeEnum DefaultProductType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDefaultMissionProductEnum.DefaultProductTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDefaultMissionProductEnum.DefaultProductTypeEnum>(value);
	}

	public GcDefaultMissionProductEnum(long address) : base(address)
	{

	}
}
