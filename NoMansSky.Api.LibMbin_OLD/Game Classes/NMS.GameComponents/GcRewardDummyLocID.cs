using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardDummyLocID : NMSTemplate
{
	public NMSString0x20A LocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcRewardDummyLocID(long address) : base(address)
	{

	}
}
