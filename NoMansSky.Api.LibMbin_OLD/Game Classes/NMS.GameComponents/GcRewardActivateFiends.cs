using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardActivateFiends : NMSTemplate
{
	public NMSString0x10 SpawnID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardActivateFiends(long address) : base(address)
	{

	}
}
