using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTileTypeOptions : NMSTemplate
{
	public VirtualList<TkPaletteTexture> Options
	{
		get => cache.GetOrAddValue(new VirtualList<TkPaletteTexture>(address + GetOffset()));
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public GcTileTypeOptions(long address) : base(address)
	{

	}
}
