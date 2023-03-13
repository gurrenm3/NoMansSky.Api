using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerMissionProgress : NMSTemplate
{
	public NMSString0x10 Mission
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Progress
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public UInt64 Seed
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 Data
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualArray<GcPlayerMissionParticipant> Participants
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerMissionParticipant>(address + GetOffset(), 13));
		set => TrySetValue<GcPlayerMissionParticipant>(value);
	}

	public GcPlayerMissionProgress(long address) : base(address)
	{

	}
}
