using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNodeID : NMSTemplate
{
	public Int32 NodeID
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcNodeID(long address) : base(address)
	{

	}
}
