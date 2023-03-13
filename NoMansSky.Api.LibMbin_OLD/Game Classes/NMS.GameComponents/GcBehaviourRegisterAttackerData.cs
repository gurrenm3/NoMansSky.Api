using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourRegisterAttackerData : NMSTemplate
{
	public NMSString0x10 TargetKey
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcBehaviourRegisterAttackerData(long address) : base(address)
	{

	}
}
