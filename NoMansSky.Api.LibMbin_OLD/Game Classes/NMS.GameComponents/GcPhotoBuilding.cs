using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoBuilding : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPhotoBuilding.PhotoBuildingTypeEnum PhotoBuildingType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPhotoBuilding.PhotoBuildingTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPhotoBuilding.PhotoBuildingTypeEnum>(value);
	}

	public GcPhotoBuilding(long address) : base(address)
	{

	}
}
