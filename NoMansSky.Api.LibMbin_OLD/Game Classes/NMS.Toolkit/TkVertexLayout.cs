using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVertexLayout : NMSTemplate
{
	public Int32 ElementCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Stride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int64 PlatformData
	{
		get => GetValue<Int64>();
		set => TrySetValue<Int64>(value);
	}

	public VirtualList<TkVertexElement> VertexElements
	{
		get => cache.GetOrAddValue(new VirtualList<TkVertexElement>(address + GetOffset()));
		set => TrySetValue<TkVertexElement>(value);
	}

	public TkVertexLayout(long address) : base(address)
	{

	}
}
