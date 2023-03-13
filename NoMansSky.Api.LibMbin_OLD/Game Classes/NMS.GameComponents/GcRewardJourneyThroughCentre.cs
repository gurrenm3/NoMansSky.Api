using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardJourneyThroughCentre : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardJourneyThroughCentre.CentreJourneyDestinationEnum CentreJourneyDestination
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardJourneyThroughCentre.CentreJourneyDestinationEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardJourneyThroughCentre.CentreJourneyDestinationEnum>(value);
	}

	public GcRewardJourneyThroughCentre(long address) : base(address)
	{

	}
}
