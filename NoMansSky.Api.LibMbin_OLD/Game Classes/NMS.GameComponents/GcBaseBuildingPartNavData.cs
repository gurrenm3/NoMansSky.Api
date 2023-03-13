using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartNavData : NMSTemplate
{
	public NMSString0x20A PartID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcBaseBuildingPartInteractionData> SharedInteractions
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPartInteractionData>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPartInteractionData>(value);
	}

	public VirtualList<GcBaseBuildingPartNavNodeData> NavNodeData
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPartNavNodeData>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPartNavNodeData>(value);
	}

	public GcBaseBuildingPartNavData(long address) : base(address)
	{

	}
}
