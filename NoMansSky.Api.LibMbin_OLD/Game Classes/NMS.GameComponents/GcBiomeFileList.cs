using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeFileList : NMSTemplate
{
	public VirtualArray<GcBiomeFileListOptions> BiomeFiles
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBiomeFileListOptions>(address + GetOffset(), 16));
		set => TrySetValue<GcBiomeFileListOptions>(value);
	}

	public VirtualList<GcBiomeType> ValidStartPlanetBiome
	{
		get => cache.GetOrAddValue(new VirtualList<GcBiomeType>(address + GetOffset()));
		set => TrySetValue<GcBiomeType>(value);
	}

	public VirtualList<GcExternalObjectListOptions> CommonExternalObjectLists
	{
		get => cache.GetOrAddValue(new VirtualList<GcExternalObjectListOptions>(address + GetOffset()));
		set => TrySetValue<GcExternalObjectListOptions>(value);
	}

	public VirtualList<GcExternalObjectFileList> OptionalExternalObjectLists
	{
		get => cache.GetOrAddValue(new VirtualList<GcExternalObjectFileList>(address + GetOffset()));
		set => TrySetValue<GcExternalObjectFileList>(value);
	}

	public GcBiomeFileList(long address) : base(address)
	{

	}
}
