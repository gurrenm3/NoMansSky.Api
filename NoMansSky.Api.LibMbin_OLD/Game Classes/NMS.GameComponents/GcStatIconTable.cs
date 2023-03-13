using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatIconTable : NMSTemplate
{
	public VirtualArray<NMSString0x80> StatIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 189));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcStatIconTable(long address) : base(address)
	{

	}
}
