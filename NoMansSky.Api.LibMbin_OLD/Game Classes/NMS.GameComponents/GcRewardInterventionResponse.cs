using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardInterventionResponse : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardInterventionResponse.ResponseTypeEnum ResponseType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardInterventionResponse.ResponseTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardInterventionResponse.ResponseTypeEnum>(value);
	}

	public NMSString0x10 MissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardInterventionResponse(long address) : base(address)
	{

	}
}
