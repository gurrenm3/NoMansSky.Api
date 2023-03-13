using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSettlementJudgement : NMSTemplate
{
	public VirtualList<GcSettlementJudgementType> JudgementTypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementJudgementType>(address + GetOffset()));
		set => TrySetValue<GcSettlementJudgementType>(value);
	}

	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSettlementJudgement(long address) : base(address)
	{

	}
}
