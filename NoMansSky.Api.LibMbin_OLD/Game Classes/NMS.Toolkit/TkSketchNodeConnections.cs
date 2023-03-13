using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkSketchNodeConnections : NMSTemplate
{
	public VirtualList<UInt32> Connections
	{
		get => cache.GetOrAddValue(new VirtualList<UInt32>(address + GetOffset()));
		set => TrySetValue<UInt32>(value);
	}

	public TkSketchNodeConnections(long address) : base(address)
	{

	}
}
