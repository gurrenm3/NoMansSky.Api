using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcColourPaletteData : NMSTemplate
{
	public VirtualArray<Colour> Colours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 5));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Int32> ColourIndices
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 5));
		set => TrySetValue<Int32>(value);
	}

	public GcColourPaletteData(long address) : base(address)
	{

	}
}
