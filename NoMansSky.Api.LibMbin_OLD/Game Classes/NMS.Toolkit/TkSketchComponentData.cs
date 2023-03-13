using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkSketchComponentData : NMSTemplate
{
	public Single GraphPosX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GraphPosY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GraphZoom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpdateRateMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<TkSketchNodeData> Nodes
	{
		get => cache.GetOrAddValue(new VirtualList<TkSketchNodeData>(address + GetOffset()));
		set => TrySetValue<TkSketchNodeData>(value);
	}

	public TkSketchComponentData(long address) : base(address)
	{

	}
}
