using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementJudgementType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSettlementJudgementType.SettlementJudgementTypeEnum SettlementJudgementType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSettlementJudgementType.SettlementJudgementTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSettlementJudgementType.SettlementJudgementTypeEnum>(value);
	}

	public GcSettlementJudgementType(long address) : base(address)
	{

	}
}
