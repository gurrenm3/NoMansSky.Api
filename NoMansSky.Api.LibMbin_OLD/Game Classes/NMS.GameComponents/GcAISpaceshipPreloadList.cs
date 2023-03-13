using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipPreloadList : NMSTemplate
{
	public GcRealityCommonFactions Faction
	{
		get => GetValue<GcRealityCommonFactions>();
		set => TrySetValue<GcRealityCommonFactions>(value);
	}

	public VirtualList<GcAISpaceshipPreloadCacheData> Cache
	{
		get => cache.GetOrAddValue(new VirtualList<GcAISpaceshipPreloadCacheData>(address + GetOffset()));
		set => TrySetValue<GcAISpaceshipPreloadCacheData>(value);
	}

	public GcAISpaceshipPreloadList(long address) : base(address)
	{

	}
}
