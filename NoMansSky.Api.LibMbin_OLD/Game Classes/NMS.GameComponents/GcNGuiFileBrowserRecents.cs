using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiFileBrowserRecents : NMSTemplate
{
	public VirtualArray<NMSString0x100> Recents
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x100>(address + GetOffset(), 10));
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcNGuiFileBrowserRecents(long address) : base(address)
	{

	}
}
