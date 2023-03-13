using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyStarColours : NMSTemplate
{
	public VirtualArray<Colour> ColourByStarType
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public GcGalaxyStarColours(long address) : base(address)
	{

	}
}
