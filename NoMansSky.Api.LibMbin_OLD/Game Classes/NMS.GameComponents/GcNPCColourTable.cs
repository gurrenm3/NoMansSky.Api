using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCColourTable : NMSTemplate
{
	public VirtualList<GcNPCColourGroup> Groups
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCColourGroup>(address + GetOffset()));
		set => TrySetValue<GcNPCColourGroup>(value);
	}

	public GcNPCColourTable(long address) : base(address)
	{

	}
}
