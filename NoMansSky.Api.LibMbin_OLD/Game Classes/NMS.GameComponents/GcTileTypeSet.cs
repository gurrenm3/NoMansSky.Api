using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTileTypeSet : NMSTemplate
{
	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<TkPaletteTexture> Colours
	{
		get => cache.GetOrAddValue(new VirtualArray<TkPaletteTexture>(address + GetOffset(), 12));
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public GcTileTypeSet(long address) : base(address)
	{

	}
}
