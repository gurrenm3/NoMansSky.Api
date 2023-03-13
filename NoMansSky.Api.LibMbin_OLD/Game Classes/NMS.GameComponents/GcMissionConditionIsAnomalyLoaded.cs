using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsAnomalyLoaded : NMSTemplate
{
	public GcGalaxyStarAnomaly Anomaly
	{
		get => GetValue<GcGalaxyStarAnomaly>();
		set => TrySetValue<GcGalaxyStarAnomaly>(value);
	}

	public GcMissionConditionIsAnomalyLoaded(long address) : base(address)
	{

	}
}
