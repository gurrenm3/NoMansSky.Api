using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDefaultMissionProduct : NMSTemplate
{
	public NMSString0x10 Product
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcDefaultMissionProduct(long address) : base(address)
	{

	}
}
