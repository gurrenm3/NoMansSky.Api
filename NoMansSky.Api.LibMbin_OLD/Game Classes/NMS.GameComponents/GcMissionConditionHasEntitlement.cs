using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasEntitlement : NMSTemplate
{
	public NMSString0x10 Entitlement
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionHasEntitlement(long address) : base(address)
	{

	}
}
