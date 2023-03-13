using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterBaseGlobals : NMSTemplate
{
	public Int32 MaxTotalNPCCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single NPCStartSpawnDelayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSpawnIntervalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTotalRoomsRequiredPerNPC
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> MaxTotalCapacityOfNPCTypes
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 5));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<GcFreighterNPCSpawnPriority> NPCTypeSpawnPriorities
	{
		get => cache.GetOrAddValue(new VirtualArray<GcFreighterNPCSpawnPriority>(address + GetOffset(), 5));
		set => TrySetValue<GcFreighterNPCSpawnPriority>(value);
	}

	public GcNPCNavSubgraphNodeTypeConnectivity NPCNavNodeConnectivity
	{
		get => GetValue<GcNPCNavSubgraphNodeTypeConnectivity>();
		set => TrySetValue<GcNPCNavSubgraphNodeTypeConnectivity>(value);
	}

	public VirtualList<GcFreighterRoomNPCData> FreighterRoomNPCData
	{
		get => cache.GetOrAddValue(new VirtualList<GcFreighterRoomNPCData>(address + GetOffset()));
		set => TrySetValue<GcFreighterRoomNPCData>(value);
	}

	public GcFreighterBaseGlobals(long address) : base(address)
	{

	}
}
