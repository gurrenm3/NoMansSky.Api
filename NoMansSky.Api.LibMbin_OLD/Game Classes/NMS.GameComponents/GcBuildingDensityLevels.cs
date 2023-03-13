using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingDensityLevels : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBuildingDensityLevels.BuildingDensityEnum BuildingDensity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBuildingDensityLevels.BuildingDensityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBuildingDensityLevels.BuildingDensityEnum>(value);
	}

	public GcBuildingDensityLevels(long address) : base(address)
	{

	}
}
