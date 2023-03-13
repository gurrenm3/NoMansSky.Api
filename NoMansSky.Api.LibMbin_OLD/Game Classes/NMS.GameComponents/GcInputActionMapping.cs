using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInputActionMapping : NMSTemplate
{
	public Int32 RemappedKey
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RemappedPad
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInputActionMapping(long address) : base(address)
	{

	}
}
