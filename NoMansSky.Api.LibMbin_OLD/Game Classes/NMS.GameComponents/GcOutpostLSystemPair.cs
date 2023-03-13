using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcOutpostLSystemPair : NMSTemplate
{
	public NMSString0x20 Locator
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualArray<NMSString0x80> LSystems
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 8));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcOutpostLSystemPair(long address) : base(address)
	{

	}
}
