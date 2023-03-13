using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasProduct : NMSTemplate
{
	public GcDefaultMissionProductEnum Default
	{
		get => GetValue<GcDefaultMissionProductEnum>();
		set => TrySetValue<GcDefaultMissionProductEnum>(value);
	}

	public NMSString0x10 Product
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean SyncWithMissionFireteam
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceSearchFreighterAndChests
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SearchEveryShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TakeAmountFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DependentOnSeasonMilestone
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 UseAmountToAffordRecipe
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean TakeAffordRecipeFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseAffordRecipeForTextFormatting
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcItemNeedPurpose Purpose
	{
		get => GetValue<GcItemNeedPurpose>();
		set => TrySetValue<GcItemNeedPurpose>(value);
	}

	public GcMissionConditionHasProduct(long address) : base(address)
	{

	}
}
