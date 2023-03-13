using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSettlementStatLevel : NMSTemplate
{
	public Single NormalisedLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSettlementStatType Stat
	{
		get => GetValue<GcSettlementStatType>();
		set => TrySetValue<GcSettlementStatType>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public GcMissionConditionSettlementStatLevel(long address) : base(address)
	{

	}
}
