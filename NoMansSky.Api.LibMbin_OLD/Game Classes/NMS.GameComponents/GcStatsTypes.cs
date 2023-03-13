using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatsTypes.StatsTypeEnum StatsType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatsTypes.StatsTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatsTypes.StatsTypeEnum>(value);
	}

	public GcStatsTypes(long address) : base(address)
	{

	}
}
