using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFontData : NMSTemplate
{
	public NMSString0x80 File
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 MinCharWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcFontData(long address) : base(address)
	{

	}
}
