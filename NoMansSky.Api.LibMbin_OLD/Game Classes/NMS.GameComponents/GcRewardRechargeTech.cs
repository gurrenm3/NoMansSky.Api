using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardRechargeTech : NMSTemplate
{
	public NMSString0x10 TechID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardRechargeTech(long address) : base(address)
	{

	}
}
