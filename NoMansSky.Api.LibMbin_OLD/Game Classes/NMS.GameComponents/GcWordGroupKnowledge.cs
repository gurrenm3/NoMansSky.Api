using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWordGroupKnowledge : NMSTemplate
{
	public NMSString0x20A Group
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Boolean> Races
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 8));
		set => TrySetValue<Boolean>(value);
	}

	public GcWordGroupKnowledge(long address) : base(address)
	{

	}
}
