using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralTechnologyStatLevel : NMSTemplate
{
	public GcStatsTypes Stat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Single ValueMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ValueMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcWeightingCurve WeightingCurve
	{
		get => GetValue<GcWeightingCurve>();
		set => TrySetValue<GcWeightingCurve>(value);
	}

	public Boolean AlwaysChoose
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcProceduralTechnologyStatLevel(long address) : base(address)
	{

	}
}
