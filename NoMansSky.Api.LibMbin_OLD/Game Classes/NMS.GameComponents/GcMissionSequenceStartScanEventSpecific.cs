using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceStartScanEventSpecific : NMSTemplate
{
	public Boolean IMeantThisAndKnowWhatItDoes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlayerMissionParticipant Participant
	{
		get => GetValue<GcPlayerMissionParticipant>();
		set => TrySetValue<GcPlayerMissionParticipant>(value);
	}

	public NMSString0x20A Event
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AllowOtherPlayersBase
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceStartScanEventSpecific(long address) : base(address)
	{

	}
}
