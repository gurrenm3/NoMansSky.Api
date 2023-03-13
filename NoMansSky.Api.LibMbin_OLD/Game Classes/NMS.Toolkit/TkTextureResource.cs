using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkTextureResource : NMSTemplate
{
	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcResource ResHandle
	{
		get => GetValue<GcResource>();
		set => TrySetValue<GcResource>(value);
	}

	public TkTextureResource(long address) : base(address)
	{

	}
}
