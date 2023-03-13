using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGeometryStreamData : NMSTemplate
{
	public VirtualList<TkMeshData> StreamDataArray
	{
		get => cache.GetOrAddValue(new VirtualList<TkMeshData>(address + GetOffset()));
		set => TrySetValue<TkMeshData>(value);
	}

	public TkGeometryStreamData(long address) : base(address)
	{

	}
}
