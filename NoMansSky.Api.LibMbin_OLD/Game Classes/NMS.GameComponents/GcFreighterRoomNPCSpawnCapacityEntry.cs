using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterRoomNPCSpawnCapacityEntry : NMSTemplate
{
	public NMSString0x10 RoomID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single SpawnCapacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFreighterRoomNPCSpawnCapacityEntry(long address) : base(address)
	{

	}
}
