using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralProductData : NMSTemplate
{
	public GcNameGeneratorWord NameGeneratorBase
	{
		get => GetValue<GcNameGeneratorWord>();
		set => TrySetValue<GcNameGeneratorWord>(value);
	}

	public VirtualList<GcProceduralProductWord> NameGeneratorWordList
	{
		get => cache.GetOrAddValue(new VirtualList<GcProceduralProductWord>(address + GetOffset()));
		set => TrySetValue<GcProceduralProductWord>(value);
	}

	public Int32 NameGeneratorLegacyRolls
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcProductData Product
	{
		get => GetValue<GcProductData>();
		set => TrySetValue<GcProductData>(value);
	}

	public VirtualArray<GcProductProceduralOnlyData> ProceduralData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcProductProceduralOnlyData>(address + GetOffset(), 3));
		set => TrySetValue<GcProductProceduralOnlyData>(value);
	}

	public GcBiomeList PerBiomeDropWeights
	{
		get => GetValue<GcBiomeList>();
		set => TrySetValue<GcBiomeList>(value);
	}

	public NMSString0x20 DeployableProductID
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean RecordsStat
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcProceduralProductData(long address) : base(address)
	{

	}
}
