using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimMetadata : NMSTemplate
{
	public Int32 FrameCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NodeCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<TkAnimNodeData> NodeData
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimNodeData>(address + GetOffset()));
		set => TrySetValue<TkAnimNodeData>(value);
	}

	public VirtualList<TkAnimNodeFrameData> AnimFrameData
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimNodeFrameData>(address + GetOffset()));
		set => TrySetValue<TkAnimNodeFrameData>(value);
	}

	public TkAnimNodeFrameData StillFrameData
	{
		get => GetValue<TkAnimNodeFrameData>();
		set => TrySetValue<TkAnimNodeFrameData>(value);
	}

	public TkAnimMetadata(long address) : base(address)
	{

	}
}
