using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceExploreAbandonedFreighter : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean RequireAllRoomsDone
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 Timer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionSequenceExploreAbandonedFreighter(long address) : base(address)
	{

	}
}
