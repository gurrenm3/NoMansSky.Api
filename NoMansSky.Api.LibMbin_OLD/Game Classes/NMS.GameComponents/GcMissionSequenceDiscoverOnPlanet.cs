using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceDiscoverOnPlanet : NMSTemplate
{
	public Single PercentToDiscover
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceDiscoverOnPlanet.DiscoverTargetOnThisPlanetEnum DiscoverTargetOnThisPlanet
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceDiscoverOnPlanet.DiscoverTargetOnThisPlanetEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceDiscoverOnPlanet.DiscoverTargetOnThisPlanetEnum>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceDiscoverOnPlanet(long address) : base(address)
	{

	}
}
