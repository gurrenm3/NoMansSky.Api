using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipModelDataArray : NMSTemplate
{
	public VirtualList<GcAISpaceshipModelData> Spaceships
	{
		get => cache.GetOrAddValue(new VirtualList<GcAISpaceshipModelData>(address + GetOffset()));
		set => TrySetValue<GcAISpaceshipModelData>(value);
	}

	public GcAISpaceshipModelDataArray(long address) : base(address)
	{

	}
}
