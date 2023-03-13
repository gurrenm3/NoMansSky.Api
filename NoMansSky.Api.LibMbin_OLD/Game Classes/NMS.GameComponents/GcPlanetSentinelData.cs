using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetSentinelData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlanetSentinelData.SentinelLevelEnum SentinelLevel
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetSentinelData.SentinelLevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetSentinelData.SentinelLevelEnum>(value);
	}

	public Int32 MaxActiveDrones
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPlanetSentinelData(long address) : base(address)
	{

	}
}
