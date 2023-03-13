using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardCommunityContribution : NMSTemplate
{
	public GcAtlasSendSubmitContribution Contribution
	{
		get => GetValue<GcAtlasSendSubmitContribution>();
		set => TrySetValue<GcAtlasSendSubmitContribution>(value);
	}

	public libMBIN.NMS.GameComponents.GcRewardCommunityContribution.SubmitTypeEnum SubmitType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardCommunityContribution.SubmitTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardCommunityContribution.SubmitTypeEnum>(value);
	}

	public NMSString0x10 Stat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 OtherStat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardCommunityContribution(long address) : base(address)
	{

	}
}
