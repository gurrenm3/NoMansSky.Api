using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkRawID : NMSTemplate
{
	public UInt64 Value0
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 Value1
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public TkRawID(long address) : base(address)
	{

	}
}
