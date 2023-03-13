using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementJudgementOption : NMSTemplate
{
	public NMSString0x20A OptionText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcSettlementJudgementPerkOption> Perks
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementJudgementPerkOption>(address + GetOffset()));
		set => TrySetValue<GcSettlementJudgementPerkOption>(value);
	}

	public Boolean HidePerkInJudgement
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcSettlementStatChange> StatChanges
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementStatChange>(address + GetOffset()));
		set => TrySetValue<GcSettlementStatChange>(value);
	}

	public VirtualList<NMSString0x10> AdditionalRewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ChainedJudgementID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean UsePolicyPerk
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsePolicyStat
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseGiftReward
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseTechPerk
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OptionIsPositiveForNPC
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSettlementJudgementOption(long address) : base(address)
	{

	}
}
