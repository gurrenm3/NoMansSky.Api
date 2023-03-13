using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourAppearData : NMSTemplate
{
	public NMSString0x10 AppearAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcBehaviourAppearData(long address) : base(address)
	{

	}
}
