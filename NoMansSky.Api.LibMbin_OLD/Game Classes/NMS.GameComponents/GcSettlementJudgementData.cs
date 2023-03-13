using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementJudgementData : NMSTemplate
{
	public GcSettlementJudgementType JudgementType
	{
		get => GetValue<GcSettlementJudgementType>();
		set => TrySetValue<GcSettlementJudgementType>(value);
	}

	public Single Weighting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A HeaderOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NPCTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A QuestionText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DilemmaText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean UseResearchLoc
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseAltResearchLoc
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSettlementJudgementOption Option1
	{
		get => GetValue<GcSettlementJudgementOption>();
		set => TrySetValue<GcSettlementJudgementOption>(value);
	}

	public GcSettlementJudgementOption Option2
	{
		get => GetValue<GcSettlementJudgementOption>();
		set => TrySetValue<GcSettlementJudgementOption>(value);
	}

	public NMSString0x10 NPC1CustomId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 NPC2CustomId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A NPC1CustomName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NPC2CustomName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 NPC1HoloEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 NPC2HoloEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcSettlementJudgementData.NPCsEnum NPCs
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSettlementJudgementData.NPCsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSettlementJudgementData.NPCsEnum>(value);
	}

	public GcSettlementJudgementData(long address) : base(address)
	{

	}
}
