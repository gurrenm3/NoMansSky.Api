using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInteractionBuffer : NMSTemplate
{
	public VirtualList<GcInteractionData> Interactions
	{
		get => cache.GetOrAddValue(new VirtualList<GcInteractionData>(address + GetOffset()));
		set => TrySetValue<GcInteractionData>(value);
	}

	public Int32 CurrentPos
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInteractionBuffer(long address) : base(address)
	{

	}
}
