using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDungeonRoomParams : NMSTemplate
{
	public NMSString0x10 RoomId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single BranchProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDungeonRoomParams(long address) : base(address)
	{

	}
}
