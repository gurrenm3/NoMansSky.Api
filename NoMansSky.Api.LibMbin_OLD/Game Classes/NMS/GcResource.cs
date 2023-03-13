using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcResource : NMSTemplate
{
	public Int32 ResourceID
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcResource(long address) : base(address)
	{

	}
}
