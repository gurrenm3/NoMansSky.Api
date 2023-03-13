using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartNavNodeData : NMSTemplate
{
	public GcNPCNavSubgraphNodeType Type
	{
		get => GetValue<GcNPCNavSubgraphNodeType>();
		set => TrySetValue<GcNPCNavSubgraphNodeType>(value);
	}

	public Vector3f LocalPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single ArriveDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f AtDir
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public NMSString0x10 InteractionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<UInt32> ConnectedNodeIndices
	{
		get => cache.GetOrAddValue(new VirtualList<UInt32>(address + GetOffset()));
		set => TrySetValue<UInt32>(value);
	}

	public GcBaseBuildingPartNavNodeData(long address) : base(address)
	{

	}
}
