using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWordKnowledge : NMSTemplate
{
	public NMSString0x10 Word
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<Boolean> Races
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 8));
		set => TrySetValue<Boolean>(value);
	}

	public GcWordKnowledge(long address) : base(address)
	{

	}
}
