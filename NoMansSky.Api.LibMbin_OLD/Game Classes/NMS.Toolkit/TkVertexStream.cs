using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVertexStream : NMSTemplate
{
	public VirtualList<Byte> VertexStream
	{
		get => cache.GetOrAddValue(new VirtualList<Byte>(address + GetOffset()));
		set => TrySetValue<Byte>(value);
	}

	public TkVertexStream(long address) : base(address)
	{

	}
}
