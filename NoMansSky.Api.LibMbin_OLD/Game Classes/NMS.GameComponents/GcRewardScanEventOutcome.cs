using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardScanEventOutcome : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardScanEventOutcome.RewardScanEventOutcomeEnum RewardScanEventOutcome
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardScanEventOutcome.RewardScanEventOutcomeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardScanEventOutcome.RewardScanEventOutcomeEnum>(value);
	}

	public GcRewardScanEventOutcome(long address) : base(address)
	{

	}
}
