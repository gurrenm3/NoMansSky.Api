using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateTraitIcons : NMSTemplate
{
	public VirtualArray<NMSString0x80> Icons
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 11));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcFrigateTraitIcons(long address) : base(address)
	{

	}
}
