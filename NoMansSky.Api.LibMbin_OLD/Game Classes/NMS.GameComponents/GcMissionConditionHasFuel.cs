using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasFuel : NMSTemplate
{
	public GcStatsTypes TargetStat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 SpecificTechID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean FormatTextAsPercentage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasFuel(long address) : base(address)
	{

	}
}
