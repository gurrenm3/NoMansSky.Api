using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class NMSString0x100 : NMSTemplate
{
	public string Value
	{
		get => GetValue<String>();
		set => TrySetValue<String>(value);
	}

	public NMSString0x100(long address) : base(address)
	{

	}
}
