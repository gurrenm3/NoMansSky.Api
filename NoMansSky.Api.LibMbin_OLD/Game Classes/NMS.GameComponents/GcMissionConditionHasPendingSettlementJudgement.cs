using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasPendingSettlementJudgement : NMSTemplate
{
	public NMSString0x10 SpecificID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionHasPendingSettlementJudgement(long address) : base(address)
	{

	}
}
