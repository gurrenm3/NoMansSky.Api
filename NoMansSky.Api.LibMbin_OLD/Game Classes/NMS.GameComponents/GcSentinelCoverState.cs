using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelCoverState : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSentinelCoverState.SentinelCoverStateEnum SentinelCoverState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSentinelCoverState.SentinelCoverStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSentinelCoverState.SentinelCoverStateEnum>(value);
	}

	public GcSentinelCoverState(long address) : base(address)
	{

	}
}
