using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerMissionParticipantType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerMissionParticipantType.ParticipantTypeEnum ParticipantType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerMissionParticipantType.ParticipantTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerMissionParticipantType.ParticipantTypeEnum>(value);
	}

	public GcPlayerMissionParticipantType(long address) : base(address)
	{

	}
}
