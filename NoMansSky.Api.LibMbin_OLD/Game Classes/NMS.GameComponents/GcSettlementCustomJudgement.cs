using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementCustomJudgement : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSettlementJudgementData Data
	{
		get => GetValue<GcSettlementJudgementData>();
		set => TrySetValue<GcSettlementJudgementData>(value);
	}

	public NMSString0x20A CustomCostText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcSettlementCustomJudgement(long address) : base(address)
	{

	}
}
