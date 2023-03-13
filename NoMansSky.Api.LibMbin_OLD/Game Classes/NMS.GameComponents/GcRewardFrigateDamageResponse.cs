using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardFrigateDamageResponse : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardFrigateDamageResponse.ResponseEnum Response
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardFrigateDamageResponse.ResponseEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardFrigateDamageResponse.ResponseEnum>(value);
	}

	public GcRewardFrigateDamageResponse(long address) : base(address)
	{

	}
}
