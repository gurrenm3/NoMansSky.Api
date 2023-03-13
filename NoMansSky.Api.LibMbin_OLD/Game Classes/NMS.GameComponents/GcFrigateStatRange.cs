using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateStatRange : NMSTemplate
{
	public Int32 Minimum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Maximum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcFrigateStatRange(long address) : base(address)
	{

	}
}
