using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimVectorBlendNode : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkAnimVectorBlendNode.BlendOperationEnum BlendOperation
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkAnimVectorBlendNode.BlendOperationEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkAnimVectorBlendNode.BlendOperationEnum>(value);
	}

	public VirtualList<TkAnimVectorBlendNodeData> BlendChildren
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimVectorBlendNodeData>(address + GetOffset()));
		set => TrySetValue<TkAnimVectorBlendNodeData>(value);
	}

	public TkAnimVectorBlendNode(long address) : base(address)
	{

	}
}
