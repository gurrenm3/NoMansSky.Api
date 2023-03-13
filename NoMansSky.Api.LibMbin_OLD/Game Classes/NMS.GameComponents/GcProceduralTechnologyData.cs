using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralTechnologyData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 Template
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Group
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 NameLower
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Subtitle
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Description
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public libMBIN.NMS.GameComponents.GcProceduralTechnologyData.QualityEnum Quality
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProceduralTechnologyData.QualityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProceduralTechnologyData.QualityEnum>(value);
	}

	public GcProceduralTechnologyCategory Category
	{
		get => GetValue<GcProceduralTechnologyCategory>();
		set => TrySetValue<GcProceduralTechnologyCategory>(value);
	}

	public Int32 NumStatsMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumStatsMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcWeightingCurve WeightingCurve
	{
		get => GetValue<GcWeightingCurve>();
		set => TrySetValue<GcWeightingCurve>(value);
	}

	public Colour UpgradeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualList<GcProceduralTechnologyStatLevel> StatLevels
	{
		get => cache.GetOrAddValue(new VirtualList<GcProceduralTechnologyStatLevel>(address + GetOffset()));
		set => TrySetValue<GcProceduralTechnologyStatLevel>(value);
	}

	public GcProceduralTechnologyData(long address) : base(address)
	{

	}
}
