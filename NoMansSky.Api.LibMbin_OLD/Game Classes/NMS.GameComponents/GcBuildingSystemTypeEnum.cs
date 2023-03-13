using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingSystemTypeEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBuildingSystemTypeEnum.BuildingSystemTypeEnum BuildingSystemType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBuildingSystemTypeEnum.BuildingSystemTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBuildingSystemTypeEnum.BuildingSystemTypeEnum>(value);
	}

	public GcBuildingSystemTypeEnum(long address) : base(address)
	{

	}
}
