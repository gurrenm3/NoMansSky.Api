using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterRoomNPCSpawnCapacities : NMSTemplate
{
	public VirtualList<GcFreighterRoomNPCSpawnCapacityEntry> RoomSpawnCapacities
	{
		get => cache.GetOrAddValue(new VirtualList<GcFreighterRoomNPCSpawnCapacityEntry>(address + GetOffset()));
		set => TrySetValue<GcFreighterRoomNPCSpawnCapacityEntry>(value);
	}

	public GcFreighterRoomNPCSpawnCapacities(long address) : base(address)
	{

	}
}
