using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMultiSpecificItemEntry : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMultiSpecificItemEntry.MultiItemRewardTypeEnum MultiItemRewardType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMultiSpecificItemEntry.MultiItemRewardTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMultiSpecificItemEntry.MultiItemRewardTypeEnum>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A ProcTechGroup
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 ProcTechQuality
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean IllegalProcTech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcProceduralProductCategory ProcProdType
	{
		get => GetValue<GcProceduralProductCategory>();
		set => TrySetValue<GcProceduralProductCategory>(value);
	}

	public GcRarity ProcProdRarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public VirtualList<NMSString0x10> CommunityTierProductList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean HideInSeasonRewards
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 SeasonRewardListFormat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMultiSpecificItemEntry(long address) : base(address)
	{

	}
}
