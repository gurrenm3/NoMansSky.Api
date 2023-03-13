using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerWeaponData : NMSTemplate
{
	public NMSString0x10 Reticle
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlayerWeaponData(long address) : base(address)
	{

	}
}
