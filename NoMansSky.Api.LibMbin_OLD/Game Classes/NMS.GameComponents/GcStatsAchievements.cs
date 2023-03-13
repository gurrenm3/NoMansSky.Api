using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsAchievements : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatsAchievements.StatsAchievementsEnum StatsAchievements
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatsAchievements.StatsAchievementsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatsAchievements.StatsAchievementsEnum>(value);
	}

	public GcStatsAchievements(long address) : base(address)
	{

	}
}
