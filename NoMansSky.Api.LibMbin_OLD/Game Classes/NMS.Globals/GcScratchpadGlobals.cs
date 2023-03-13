using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScratchpadGlobals : NMSTemplate
{
	public VirtualList<GcPresetTextureData> IBLMaps
	{
		get => cache.GetOrAddValue(new VirtualList<GcPresetTextureData>(address + GetOffset()));
		set => TrySetValue<GcPresetTextureData>(value);
	}

	public VirtualList<GcPresetTextureData> TerrainTextures
	{
		get => cache.GetOrAddValue(new VirtualList<GcPresetTextureData>(address + GetOffset()));
		set => TrySetValue<GcPresetTextureData>(value);
	}

	public VirtualList<GcPresetTextureData> OverlayTextures
	{
		get => cache.GetOrAddValue(new VirtualList<GcPresetTextureData>(address + GetOffset()));
		set => TrySetValue<GcPresetTextureData>(value);
	}

	public VirtualList<Colour> TerrainColours
	{
		get => cache.GetOrAddValue(new VirtualList<Colour>(address + GetOffset()));
		set => TrySetValue<Colour>(value);
	}

	public GcScratchpadGlobals(long address) : base(address)
	{

	}
}
