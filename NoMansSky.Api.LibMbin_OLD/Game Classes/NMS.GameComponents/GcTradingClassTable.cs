using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTradingClassTable : NMSTemplate
{
	public VirtualArray<GcTradingClassData> TradingClassesData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcTradingClassData>(address + GetOffset(), 7));
		set => TrySetValue<GcTradingClassData>(value);
	}

	public VirtualArray<GcTradingCategoryData> CategoryData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcTradingCategoryData>(address + GetOffset(), 9));
		set => TrySetValue<GcTradingCategoryData>(value);
	}

	public Single MaxTradingMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTradingMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTradingClassTable(long address) : base(address)
	{

	}
}
