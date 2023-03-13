using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class NMSString0x200 : NMSTemplate
{
	public string Value
	{
		get => GetValue<String>();
		set => TrySetValue<String>(value);
	}

	public NMSString0x200(long address) : base(address)
	{

	}
}
