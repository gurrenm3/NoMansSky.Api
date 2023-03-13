using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkRandomComponentData : NMSTemplate
{
	public Int32 Seed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkRandomComponentData(long address) : base(address)
	{

	}
}
