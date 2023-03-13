using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourIncrementCounter : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcBehaviourIncrementCounter(long address) : base(address)
	{

	}
}
