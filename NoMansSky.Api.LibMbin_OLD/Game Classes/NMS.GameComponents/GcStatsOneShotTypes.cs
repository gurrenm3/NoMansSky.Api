using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsOneShotTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatsOneShotTypes.StatsOneShotEnum StatsOneShot
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatsOneShotTypes.StatsOneShotEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatsOneShotTypes.StatsOneShotEnum>(value);
	}

	public GcStatsOneShotTypes(long address) : base(address)
	{

	}
}
