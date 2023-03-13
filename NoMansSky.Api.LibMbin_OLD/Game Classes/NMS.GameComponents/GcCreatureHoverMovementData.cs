using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureHoverMovementData : NMSTemplate
{
	public VirtualList<GcCreatureHoverMovementDataParams> Params
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureHoverMovementDataParams>(address + GetOffset()));
		set => TrySetValue<GcCreatureHoverMovementDataParams>(value);
	}

	public GcCreatureHoverMovementData(long address) : base(address)
	{

	}
}
