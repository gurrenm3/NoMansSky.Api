using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLodAction : NMSTemplate
{
	public Int32 LodOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcLodAction(long address) : base(address)
	{

	}
}
