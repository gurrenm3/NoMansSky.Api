using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyStarAnomaly : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcGalaxyStarAnomaly.GalaxyStarAnomalyEnum GalaxyStarAnomaly
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGalaxyStarAnomaly.GalaxyStarAnomalyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGalaxyStarAnomaly.GalaxyStarAnomalyEnum>(value);
	}

	public GcGalaxyStarAnomaly(long address) : base(address)
	{

	}
}
