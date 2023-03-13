using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSettlementStat : NMSTemplate
{
	public GcSettlementStatChange StatToAward
	{
		get => GetValue<GcSettlementStatChange>();
		set => TrySetValue<GcSettlementStatChange>(value);
	}

	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSettlementStat(long address) : base(address)
	{

	}
}
