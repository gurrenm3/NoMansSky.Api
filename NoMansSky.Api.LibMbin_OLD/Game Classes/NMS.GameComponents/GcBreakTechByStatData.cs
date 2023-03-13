using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBreakTechByStatData : NMSTemplate
{
	public GcStatsTypes DamageTechWithStat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Boolean IncludeStatChildren
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBreakTechByStatData(long address) : base(address)
	{

	}
}
