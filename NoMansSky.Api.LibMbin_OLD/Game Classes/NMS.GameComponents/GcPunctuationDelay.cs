using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPunctuationDelay : NMSTemplate
{
	public NMSString0x20 Punctuation
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single Delay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPunctuationDelay(long address) : base(address)
	{

	}
}
