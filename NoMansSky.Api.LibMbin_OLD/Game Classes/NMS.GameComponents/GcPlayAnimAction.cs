using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayAnimAction : NMSTemplate
{
	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPlayAnimAction(long address) : base(address)
	{

	}
}
