using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceCompleteSettlementJudgement : NMSTemplate
{
	public VirtualArray<GcJudgementMessageOptions> MessageOptions
	{
		get => cache.GetOrAddValue(new VirtualArray<GcJudgementMessageOptions>(address + GetOffset(), 7));
		set => TrySetValue<GcJudgementMessageOptions>(value);
	}

	public GcJudgementMessageOptions MessageNoOffice
	{
		get => GetValue<GcJudgementMessageOptions>();
		set => TrySetValue<GcJudgementMessageOptions>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceCompleteSettlementJudgement(long address) : base(address)
	{

	}
}
