using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterRoomNPCData : NMSTemplate
{
	public NMSString0x10 RoomID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<Single> SpawnCapacity
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> POISelectionWeight
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public GcFreighterRoomNPCData(long address) : base(address)
	{

	}
}
