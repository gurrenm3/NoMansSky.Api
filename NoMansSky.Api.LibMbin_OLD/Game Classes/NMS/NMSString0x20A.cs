using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class NMSString0x20A : NMSTemplate
{
	public string Value
	{
		get => GetValue<String>();
		set => TrySetValue<String>(value);
	}

	public NMSString0x20A(long address) : base(address)
	{

	}
}
