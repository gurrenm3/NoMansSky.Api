using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcJourneyMedalType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcJourneyMedalType.MedalTypeEnum MedalType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcJourneyMedalType.MedalTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcJourneyMedalType.MedalTypeEnum>(value);
	}

	public GcJourneyMedalType(long address) : base(address)
	{

	}
}
