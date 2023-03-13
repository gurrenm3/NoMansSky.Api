using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNameGeneratorWord : NMSTemplate
{
	public NMSString0x20A Word
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 NumOptions
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcNameGeneratorWord(long address) : base(address)
	{

	}
}
