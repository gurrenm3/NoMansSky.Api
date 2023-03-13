using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSpawnTable : NMSTemplate
{
	public VirtualArray<NMSString0x80> NPCModelNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 8));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<Single> NPCRaceScale
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 8));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcUniqueNPCSpawnData> UniqueNPCs
	{
		get => cache.GetOrAddValue(new VirtualList<GcUniqueNPCSpawnData>(address + GetOffset()));
		set => TrySetValue<GcUniqueNPCSpawnData>(value);
	}

	public VirtualList<GcNPCPlacementInfo> PlacementInfos
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCPlacementInfo>(address + GetOffset()));
		set => TrySetValue<GcNPCPlacementInfo>(value);
	}

	public GcNPCSpawnTable(long address) : base(address)
	{

	}
}
