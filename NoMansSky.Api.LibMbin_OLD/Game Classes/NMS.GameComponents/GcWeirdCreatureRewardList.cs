using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeirdCreatureRewardList : NMSTemplate
{
	public VirtualArray<NMSString0x10> Rewards
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 27));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcWeirdCreatureRewardList(long address) : base(address)
	{

	}
}
