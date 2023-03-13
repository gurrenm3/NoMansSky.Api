using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetAccessoryInfo : NMSTemplate
{
	public NMSString0x20A Descriptor
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPetAccessoryInfo(long address) : base(address)
	{

	}
}
