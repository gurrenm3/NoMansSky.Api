using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBootLogoData : NMSTemplate
{
	public VirtualArray<NMSString0x100> Textures
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x100>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x100>(value);
	}

	public VirtualArray<Single> DisplayTime
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public GcBootLogoData(long address) : base(address)
	{

	}
}
