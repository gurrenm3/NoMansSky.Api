using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSceneOptions : NMSTemplate
{
	public Int32 RecentToolboxIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SelectedToolboxIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean OverrideBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 BiomeFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean OverrideWaterBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 WaterBiomeFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean OverrideCaveBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 CaveBiomeFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean OverrideTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 TerrainFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean OverrideAtmosphere
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 AtmosphereFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<Vector3f> ForceResource
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public Single ForceResourceSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSceneOptions(long address) : base(address)
	{

	}
}
