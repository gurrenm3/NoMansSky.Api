using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetSize : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlanetSize.PlanetSizeEnum PlanetSize
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetSize.PlanetSizeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetSize.PlanetSizeEnum>(value);
	}

	public GcPlanetSize(long address) : base(address)
	{

	}
}
