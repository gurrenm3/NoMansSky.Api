using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSavedEntitlement : NMSTemplate
{
	public NMSString0x100 EntitlementId
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcSavedEntitlement(long address) : base(address)
	{

	}
}
