using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardShipAssistance : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardShipAssistance.AssistanceTypeEnum AssistanceType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardShipAssistance.AssistanceTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardShipAssistance.AssistanceTypeEnum>(value);
	}

	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRewardShipAssistance(long address) : base(address)
	{

	}
}
