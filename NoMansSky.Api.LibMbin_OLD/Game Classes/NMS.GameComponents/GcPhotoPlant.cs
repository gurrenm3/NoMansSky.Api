using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoPlant : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPhotoPlant.PhotoPlantTypeEnum PhotoPlantType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPhotoPlant.PhotoPlantTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPhotoPlant.PhotoPlantTypeEnum>(value);
	}

	public GcPhotoPlant(long address) : base(address)
	{

	}
}
