using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionIDEpochPair : NMSTemplate
{
	public NMSString0x10 MissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public UInt64 RecurrenceDeadline
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcMissionIDEpochPair(long address) : base(address)
	{

	}
}
