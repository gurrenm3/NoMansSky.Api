using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGrabbableComponentData : NMSTemplate
{
	public VirtualList<GcGrabbableData> GrabbableDataArray
	{
		get => cache.GetOrAddValue(new VirtualList<GcGrabbableData>(address + GetOffset()));
		set => TrySetValue<GcGrabbableData>(value);
	}

	public GcGrabbableComponentData(long address) : base(address)
	{

	}
}
