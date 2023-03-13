using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasDiscoveryMetadata : NMSTemplate
{
	public NMSString0x80 CustomName
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcAtlasDiscoveryMetadata(long address) : base(address)
	{

	}
}
