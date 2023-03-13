using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsScanEventOnCurrentPlanet : NMSTemplate
{
	public NMSString0x20A Event
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean AllowInShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionIsScanEventOnCurrentPlanet(long address) : base(address)
	{

	}
}
