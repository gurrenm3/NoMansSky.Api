using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasSubstance : NMSTemplate
{
	public GcDefaultMissionSubstanceEnum Default
	{
		get => GetValue<GcDefaultMissionSubstanceEnum>();
		set => TrySetValue<GcDefaultMissionSubstanceEnum>(value);
	}

	public NMSString0x10 Substance
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean TakeAmountFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcItemNeedPurpose Purpose
	{
		get => GetValue<GcItemNeedPurpose>();
		set => TrySetValue<GcItemNeedPurpose>(value);
	}

	public GcMissionConditionHasSubstance(long address) : base(address)
	{

	}
}
