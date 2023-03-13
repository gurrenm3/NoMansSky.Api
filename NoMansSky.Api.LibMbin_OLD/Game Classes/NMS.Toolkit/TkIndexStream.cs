using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkIndexStream : NMSTemplate
{
	public VirtualList<Int32> IndexStream
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public TkIndexStream(long address) : base(address)
	{

	}
}
