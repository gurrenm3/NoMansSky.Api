using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationColourPaletteExtraData : NMSTemplate
{
	public VirtualList<NMSString0x10> ProductToUnlock
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x20A> TipText
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCustomisationColourPaletteExtraData(long address) : base(address)
	{

	}
}
