using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyStarTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcGalaxyStarTypes.GalaxyStarTypeEnum GalaxyStarType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGalaxyStarTypes.GalaxyStarTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGalaxyStarTypes.GalaxyStarTypeEnum>(value);
	}

	public GcGalaxyStarTypes(long address) : base(address)
	{

	}
}
