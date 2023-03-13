using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourCooldownBeginData : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcBehaviourCooldownBeginData(long address) : base(address)
	{

	}
}
