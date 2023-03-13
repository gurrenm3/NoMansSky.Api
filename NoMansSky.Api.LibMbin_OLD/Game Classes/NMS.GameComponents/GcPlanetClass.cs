using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetClass : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlanetClass.PlanetClassEnum PlanetClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetClass.PlanetClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetClass.PlanetClassEnum>(value);
	}

	public GcPlanetClass(long address) : base(address)
	{

	}
}
