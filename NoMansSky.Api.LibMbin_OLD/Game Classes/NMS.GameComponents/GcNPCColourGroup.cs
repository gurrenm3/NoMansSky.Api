using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCColourGroup : NMSTemplate
{
	public Single Rarity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour Primary
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualList<Colour> Secondary
	{
		get => cache.GetOrAddValue(new VirtualList<Colour>(address + GetOffset()));
		set => TrySetValue<Colour>(value);
	}

	public GcNPCColourGroup(long address) : base(address)
	{

	}
}
