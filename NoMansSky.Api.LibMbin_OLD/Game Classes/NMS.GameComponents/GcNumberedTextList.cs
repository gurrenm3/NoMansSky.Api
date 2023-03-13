using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNumberedTextList : NMSTemplate
{
	public NMSString0x20 Format
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Int32 Count
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcNumberedTextList(long address) : base(address)
	{

	}
}
