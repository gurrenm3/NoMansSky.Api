using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementJudgementPerkOption : NMSTemplate
{
	public NMSString0x10 Perk
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single PerkChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSettlementJudgementPerkOption(long address) : base(address)
	{

	}
}
