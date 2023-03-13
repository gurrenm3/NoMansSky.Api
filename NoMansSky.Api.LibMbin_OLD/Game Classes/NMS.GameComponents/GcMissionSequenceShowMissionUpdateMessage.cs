using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionSequenceShowMissionUpdateMessage.MissionUpdateMessageEnum MissionUpdateMessage
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceShowMissionUpdateMessage.MissionUpdateMessageEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceShowMissionUpdateMessage.MissionUpdateMessageEnum>(value);
	}

	public NMSString0x20A CustomMessageLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A CustomObjectiveLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean SetMissionSelected
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean WaitForMessageOver
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowChangeMissionNotify
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceShowMissionUpdateMessage.PlayMusicStingEnum PlayMusicSting
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceShowMissionUpdateMessage.PlayMusicStingEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceShowMissionUpdateMessage.PlayMusicStingEnum>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceShowMissionUpdateMessage(long address) : base(address)
	{

	}
}
