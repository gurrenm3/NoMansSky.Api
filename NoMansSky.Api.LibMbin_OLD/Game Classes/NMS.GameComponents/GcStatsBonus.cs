using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsBonus : NMSTemplate
{
	public GcStatsTypes Stat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Single Bonus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Level
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcStatsBonus(long address) : base(address)
	{

	}
}
