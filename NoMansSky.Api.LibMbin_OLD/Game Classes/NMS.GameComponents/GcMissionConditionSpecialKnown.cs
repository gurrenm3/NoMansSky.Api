using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSpecialKnown : NMSTemplate
{
	public NMSString0x10 SpecialID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionSpecialKnown(long address) : base(address)
	{

	}
}
