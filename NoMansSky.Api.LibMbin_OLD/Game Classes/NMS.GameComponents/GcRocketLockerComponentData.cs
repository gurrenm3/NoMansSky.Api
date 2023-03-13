using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRocketLockerComponentData : NMSTemplate
{
	public Int32 NumSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRocketLockerComponentData(long address) : base(address)
	{

	}
}
