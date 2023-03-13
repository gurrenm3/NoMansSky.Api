using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsValueTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatsValueTypes.StatsValueEnum StatsValue
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatsValueTypes.StatsValueEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatsValueTypes.StatsValueEnum>(value);
	}

	public GcStatsValueTypes(long address) : base(address)
	{

	}
}
