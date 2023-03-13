using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryBaseStatBonus : NMSTemplate
{
	public GcStatsTypes StatType
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Boolean LessIsBetter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInventoryBaseStatBonus(long address) : base(address)
	{

	}
}
