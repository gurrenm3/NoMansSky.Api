using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceWaitForStatMilestone : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 Stat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceWaitForStatMilestone.MilestoneEnum Milestone
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceWaitForStatMilestone.MilestoneEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceWaitForStatMilestone.MilestoneEnum>(value);
	}

	public Boolean EveryMilestone
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceWaitForStatMilestone(long address) : base(address)
	{

	}
}
