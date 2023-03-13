using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class NMSString0x80 : NMSTemplate
{
	public string Value
	{
		get => GetValue<String>();
		set => TrySetValue<String>(value);
	}

	public NMSString0x80(long address) : base(address)
	{

	}
}
