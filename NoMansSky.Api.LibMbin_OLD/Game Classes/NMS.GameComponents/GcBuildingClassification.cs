using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingClassification : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBuildingClassification.BuildingClassEnum BuildingClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBuildingClassification.BuildingClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBuildingClassification.BuildingClassEnum>(value);
	}

	public GcBuildingClassification(long address) : base(address)
	{

	}
}
