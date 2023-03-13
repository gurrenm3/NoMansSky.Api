using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemGlobalVariation : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 Model
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 Variations
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkLSystemGlobalVariation(long address) : base(address)
	{

	}
}
