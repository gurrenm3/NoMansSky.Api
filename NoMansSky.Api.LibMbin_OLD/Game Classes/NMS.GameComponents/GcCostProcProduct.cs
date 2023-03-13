using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostProcProduct : NMSTemplate
{
	public GcProceduralProductCategory Type
	{
		get => GetValue<GcProceduralProductCategory>();
		set => TrySetValue<GcProceduralProductCategory>(value);
	}

	public Boolean CareAboutRarity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRarity Rarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public Int32 FreighterPasswordIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostProcProduct(long address) : base(address)
	{

	}
}
