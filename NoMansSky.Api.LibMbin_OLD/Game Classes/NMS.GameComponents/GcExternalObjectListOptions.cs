using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExternalObjectListOptions : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ResourceHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ResourceHintIcon
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SeasonalProbabilityOverride
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTerrainTileType TileType
	{
		get => GetValue<GcTerrainTileType>();
		set => TrySetValue<GcTerrainTileType>(value);
	}

	public Boolean AllowLimiting
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ChooseUsingLifeLevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSString0x80> Options
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcExternalObjectListOptions(long address) : base(address)
	{

	}
}
